using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.SFMLInput
{
    class Keyboard : BlinkByte.Input.IDevice
    {
        Dictionary<string,SFML.Window.Keyboard.Key> keys = new Dictionary<string, SFML.Window.Keyboard.Key>();
        
        public bool GetButton(string button)
        {
            
            
            if (hasButton(button))
            {
               return SFML.Window.Keyboard.IsKeyPressed(keys[button]);
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
                keys.Add(button, (SFML.Window.Keyboard.Key)buttonObj);
            }
            return this;
        }
        public BlinkByte.Input.IDevice addButton(string button, int buttonint)
        {
            if (!hasButton(button))
            {
                keys.Add(button, (SFML.Window.Keyboard.Key)buttonint);
            }
            return this;
        }
    }
}
