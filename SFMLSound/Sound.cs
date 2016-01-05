using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.SFMLSound
{
    public class Sound : BlinkByte.Sound.ISound
    {
        public void init(){
        SFML.Audio.SoundBuffer buffer = new SFML.Audio.SoundBuffer("sound.wav");
//buffer.loadFromFile("sound.wav");

SFML.Audio.Sound sound = new SFML.Audio.Sound(buffer);
//sound.setBuffer(buffer);
sound.Play();   
        }
    }
}
