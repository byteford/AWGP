using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Reflection;

namespace BlinkByte.Core
{
    [System.Serializable]
    public class Scene
    {
        /// <summary>
        ///Get the currently loaded scene 
        /// </summary>
        public static Scene currentScene;
        public List<GameObject> GameObjects;
        ServiceContainer methods = new ServiceContainer();
        public Scene()
        {
            currentScene = this;
            GameObjects = new List<GameObject>();
        }
        /// <summary>
        /// Runs start of all inishilised game objects
        /// </summary>
        public void Start()
        {
            foreach(var go in GameObjects)
            {
                go.Start();
            }
        }
        public GameObject addGameObject(GameObject obj)
        {
            GameObjects.Add(obj);
            return obj;
        }
        /// <summary>
        /// save the current scene to a file
        /// </summary>
        /// <param name="fileName">relitive locaiton to save</param>
        public void saveToFile(string fileName)
        {
            IO.LoadFromFile.SaveFile(fileName, this);
        }
        /// <summary>
        /// Runs the update of every gameobject and keeps track of time since last update
        /// </summary>
        public void Update()
        {
            foreach( GameObject go in GameObjects)
            {
                go.Update();
            }
            Time.Reset();
        }
        public void RunMethodCall<T>(string method, object[] args)
        {
            List < T > list = GetServices<T>();
            if(list == null)
            {
                return;
            }
            MethodInfo info;
            foreach (var temp in list)
            {
                info = typeof(T).GetMethod(method);
                info.Invoke(temp,new[] { args});
            }
            
        }
        public T addMethodCall<T>(T methodClass)
        {
            AddService<T>();
            (methods.GetService(typeof(List<T>)) as List<T>).Add(methodClass);
            return methodClass;
        }
        private bool hasService<T>()
        {
            if (methods.GetService(typeof(List<T>)) != null ){
                return true;
            }
            
            return false;
        }
        private void AddService<T>()
        {
            if (!hasService<T>())
            {
                methods.AddService(typeof(List<T>), new List<T>());
            }
        }
        private List<T> GetServices<T>()
        {
            if (hasService<T>())
            {
                return methods.GetService(typeof(List<T>)) as List<T>;
            }
            else
                return null;
        }
    }
}
