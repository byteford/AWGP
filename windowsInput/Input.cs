using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;

namespace BlinkByte.windowsInput
{
    public class Input : BlinkByte.Input.IInput
    {
        public ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Input;
        }

        public void Init()
        {
            Console.WriteLine("Input Started");
        }

        public void Update()
        {
           
        }
    }
}
