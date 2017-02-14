using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Module
{
    public interface IModule
    {
        /// <summary>
        /// Run to Inishilise module
        /// </summary>
        void Init();
        /// <summary>
        /// Runs every frame
        /// </summary>
        void Update();
        ModuleType GetModuleType();
    }
}
