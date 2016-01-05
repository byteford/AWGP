using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
namespace BlinkByte.SFMLInput
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
            BlinkByte.Input.Input.addDevice("keyboard", new Keyboard()).addButton("a", SFML.Window.Keyboard.Key.A).addButton("s", SFML.Window.Keyboard.Key.S)
                                                                        .addButton("d", SFML.Window.Keyboard.Key.D).addButton("w", SFML.Window.Keyboard.Key.W);
        }

        public void Update()
        {
           
        }
    }
}
