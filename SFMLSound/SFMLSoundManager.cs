﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;

namespace BlinkByte.SFMLSound
{

    public class SFMLSoundManager : BlinkByte.Sound.ISound
    {
        Dictionary<string, SFML.Audio.Sound> Audios = new Dictionary<string, SFML.Audio.Sound>();
        public static SFMLSoundManager instance;

        SFML.Audio.SoundBuffer buffer ;

        public void playSound(string filename)
        {
            loadsound(filename);
            Audios[filename].Play();

        }

        public void stopSound(string filename)
        {
            loadsound(filename);
            Audios[filename].Stop();

        }

        public void pauseSound(string filename)
        {
            loadsound(filename);
            Audios[filename].Pause();
        
        }
        public void loopSound(string filename,bool Loop) 
        {
            loadsound(filename);
            Audios[filename].Loop = Loop;
        
        }
        public void pitchSound(string filename, float pitch)
        {
            loadsound(filename);
            Audios[filename].Pitch = pitch;
        }
        public void volumeSound(string filename, float volume)
        {
            loadsound(filename);
            Audios[filename].Volume = volume;
        }
        private void loadsound(string filename)
        {
            if (!Audios.ContainsKey(filename))
            {

                buffer = new SFML.Audio.SoundBuffer(filename);
                Audios.Add(filename,new SFML.Audio.Sound(buffer));

            }
        }

       
        public void Init()
        {
            instance = this;
            
            //sound.setBuffer(buffer);
           

            



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
