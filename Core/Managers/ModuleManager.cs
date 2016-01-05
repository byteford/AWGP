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
        public void Init()
        {
            
            foreach(IModule Mod in modules.Values)
            {
                Mod.Init();
            }
        }
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
