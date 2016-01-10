using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Utilitys;
namespace BlinkByte.SFMLGraphics
{
    public class SFMLTextComp: BlinkByte.Graphics.Componates.TextComp
    {
        SFML.Graphics.Text SFMLText;
        public SFMLTextComp() : base()
        {
            SFMLText = new SFML.Graphics.Text("", new SFML.Graphics.Font(FontLocation));
        }
        public override void Draw()
        {
            SFMLText.Position = gameObject.GetTransform().Position.convert();
            SFMLText.DisplayedString = getText();
            SFMLText.CharacterSize = (uint)getSize();
            WindowManager.getInstance().getRenderWin().Draw(SFMLText);
            base.Draw();
        }
    }
}
