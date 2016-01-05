using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
using System.Windows.Input;
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
            BlinkByte.Input.Input.addDevice("keyboard", new Keyboard()).addButton("a", Key.A) ;
        }

        public void Update()
        {
            if (BlinkByte.Input.Input.ButtonDown("a")) ;
        }
    }
}
