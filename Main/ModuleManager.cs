using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
namespace BlinkByte.Main
{
    public class ModuleManager: BlinkByte.Core.IManager
    {
        public Dictionary<ModuleType, IModule> modules;
        
        public ModuleManager()
        {
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
