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
        public Dictionary<ModuleType, IModule> modules;
        public static ModuleManager instance;
        
        public ModuleManager()
        {
            instance = this;
            modules = new Dictionary<ModuleType, IModule>();
        }
        public void Init()
        {
            
            foreach(IModule Mod in modules.Values)
            {
                Mod.Init();
            }
        }
        public void AddManager(IModule module)
        {
            modules.Add(module.GetModuleType(), module);
        }
    }
}
