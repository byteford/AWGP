using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
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
            T temp = (T)Activator.CreateInstance(typeof(T));
            if ((temp as IModule) != null)
            {
                modules.Add(typeof(T), temp as IModule);
                return temp;
            }
            return default(T);
        }
    }
}
