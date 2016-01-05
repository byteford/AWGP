using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.SFMLSound
{
    public class Sound : BlinkByte.Sound.ISound
    {       SFML.Audio.SoundBuffer buffer = new SFML.Audio.SoundBuffer("Audios/orchestral.ogg");
            //buffer.loadFromFile("sound.wav");
    SFML.Audio.Sound sound;
          

        public void Init()
        {
            sound = new SFML.Audio.Sound(buffer); 
            sound.Play();
            //sound.setBuffer(buffer);
           
           // sound.Loop =true;

            Console.WriteLine("sound Started");
        }

        public void Update()
        {
           
        }

        public Core.Module.ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Sounds;
        }
    }
}
