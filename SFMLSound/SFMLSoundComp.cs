using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Sound;
namespace BlinkByte.SFMLSound
{
    public class SFMLSoundComp : BlinkByte.Sound.SoundComp
    {
        
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
                pitchSound(0.2f);

            }
        }

        public override SoundComp playSound()
        {
            SFMLSoundManager.instance.playSound(filename);
            return base.playSound();
        }

        public override SoundComp stopSound()
        {
            SFMLSoundManager.instance.stopSound(filename);
            return base.stopSound();
        }
        public override SoundComp pauseSound()
        {
            SFMLSoundManager.instance.pauseSound(filename);
            return base.pauseSound();
        }
                public override SoundComp loopSound(bool Loop)
        {
            SFMLSoundManager.instance.loopSound(filename, Loop);
            return base.loopSound(Loop);
        }
       
        public override SoundComp pitchSound(float pitch)
        {
            SFMLSoundManager.instance.pitchSound(filename, pitch);
            return base.pitchSound(pitch);
        }

        public override SoundComp volumeSound(float Volume) 
        {
            SFMLSoundManager.instance.volumeSound(filename, Volume);
            return base.volumeSound(Volume);

        }
    }
}
