using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.SFMLSound
{
    public class SFMLSoundComp : BlinkByte.Sound.SoundComp
    {
        public bool playOnStart = true;
       public string filename;
        public void setFileName(string filename)
        {
            this.filename = filename;



        }

        public override void Start(Core.GameObject gameObject)
        {
            base.Start(gameObject);
            if (playOnStart)
            {
                playSound();
            }
        } 

        public void playSound()
        {
            SFMLSoundManager.instance.playSound(filename);

        }
        public void stopSound()
        {
            SFMLSoundManager.instance.stopSound(filename);

        }

    }
}
