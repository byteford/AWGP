using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Sound
{
   public class SoundComp: BlinkByte.Core.Component.Component
    {
        public bool playOnStart = true;
        public string filename;
        public virtual SoundComp playSound()
        {
             return this;
        }

        public virtual SoundComp stopSound()
        {
           
            return this;
        }
        public virtual SoundComp pauseSound()
        {
      
            return this;
        }
        public virtual SoundComp loopSound(bool Loop)
        {
            
            return this;
        }

        public virtual SoundComp pitchSound(float pitch)
        {
            
            return this;
        }

        public virtual SoundComp volumeSound(float Volume)
        {
          
            return this;

        }

    }

}