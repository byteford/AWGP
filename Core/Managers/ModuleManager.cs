using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
using System.Reflection;

namespace BlinkByte.Core.Managers
{
    public class ModuleManager: IManager
    {
        public Dictionary<Type, IModule> modules;
        public static ModuleManager instance;
        
        public ModuleManager()
        {
            instance = this;
            modules = new Dictionary<Type, IModule>();
        }
        /// <summary>
        /// Inishilises the modules that have been loaded
        /// </summary>
        public void Init()
        {
            
            foreach(IModule Mod in modules.Values)
            {
                Mod.Init();
            }
        }
        /// <summary>
        /// Runs Update on modules that need it (mainly for drawing)
        /// </summary>
        public void Update()
        {
            foreach (IModule Mod in modules.Values)
            {
                Mod.Update();
            }
        }
        public T AddManager<T>()
        {
            /*  T temp = (T)Activator.CreateInstance(typeof(T));
              if ((temp as IModule) != null)
              {
                  modules.Add(typeof(T), temp as IModule);
                  return temp;
              }
              return default(T);*/
            return (T)AddManager(typeof(T));
        }
        /// <summary>
        /// Adds a manager to the modules Dictonary, Loads a dll if the dll isnt already loaded
        /// </summary>
        /// <param name="dllName"> The name of the dll to load</param>
        /// <param name="TypeName">The name of the base class, including namespace</param>
        /// <returns></returns>
        public object AddManager(string dllName, string TypeName)
        {
            Assembly asm;
            try
            {
                Assembly[] arr = AppDomain.CurrentDomain.GetAssemblies();
                asm = arr.First(x => x.ManifestModule.Name == dllName);
            }catch(Exception e)
            {
                try {
                    asm = Assembly.Load(dllName.Replace(".dll", ""));
                }
                catch(Exception)
                {
                    Console.WriteLine("cant find: " + dllName);
                    asm = null;
                }
            }
           return AddManager(asm.GetType(TypeName));
        }
        /// <summary>
        /// Creates an instance of a module and adds it to the modules dictonary
        /// </summary>
        /// <param name="type">the type of module to add to the modules dictonary</param>
        /// <returns></returns>
        private object AddManager(Type type)
        {
            object temp = Activator.CreateInstance(type);
            if ((temp as IModule) != null)
            {
                modules.Add(type, temp as IModule);
                return temp;
            }
            return null;
        }        
    }
}
