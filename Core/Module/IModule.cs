using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Module
{
    public interface IModule
    {
        void Init();
        void Update();
        ModuleType GetModuleType();
    }
}
