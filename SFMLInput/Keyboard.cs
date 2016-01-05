using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlinkByte.windowsInput
{
    class Keyboard : BlinkByte.Input.IDevice
    {
        Dictionary<string,Key> keys = new Dictionary<string, Key>();
        
        public bool GetButton(string button)
        {
            
            
            if (hasButton(button))
            {
               return System.Windows.Input.Keyboard.IsKeyDown(keys[button]);
            }
            return false;
        }

        public bool hasButton(string button)
        {
            return keys.ContainsKey(button);
        }
        public BlinkByte.Input.IDevice addButton(string button, object buttonObj)
        {
            if (!hasButton(button)){
                keys.Add(button, (Key)buttonObj);
            }
            return this;
        }
    }
}
