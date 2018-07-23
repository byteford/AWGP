using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Utilitys;
namespace BlinkByte.SFMLGraphics
{
    public class SFMLSquare2DComp : BlinkByte.Graphics.Componates.Square2DComp
    {
        SFML.Graphics.RectangleShape SFMLShape;
        public SFMLSquare2DComp():base(){
            SFMLShape = new SFML.Graphics.RectangleShape();
        }
        public override void Draw()
        {
            SFMLShape.Size = new SFML.System.Vector2f(width, height);
            SFMLShape.FillColor = getColor().convert();
            if (gameObject.GetTransform() != null)
                SFMLShape.Position = gameObject.GetTransform().Position.convert();
            WindowManager.getInstance().getRenderWin().Draw(SFMLShape);
        }

    }
}
