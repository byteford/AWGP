using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Utilitys;
namespace BlinkByte.SFMLGraphics
{
    public class SFMLCircle2DComp: BlinkByte.Graphics.Componates.Circle2DComp
    {
        
        SFML.Graphics.CircleShape SFMLShape;
        public SFMLCircle2DComp():base(){
            SFMLShape = new SFML.Graphics.CircleShape();
        }
        public override void Draw()
        {
            SFMLShape.Radius = 50;
            SFMLShape.Scale = gameObject.GetTransform().Scale.convert();
            SFMLShape.Rotation = gameObject.GetTransform().Rotation;
            SFMLShape.FillColor = getColor().convert();
            if(gameObject.GetTransform() != null)
            SFMLShape.Position = gameObject.GetTransform().Position.convert();
            WindowManager.getInstance().getRenderWin().Draw(SFMLShape);
        }
        //public static void Draw(this BlinkByte.Graphics.Componates.Shape2DComp comp, SFML.Graphics.RenderWindow wind)
        //{
        //    if (comp.shape == Graphics.Componates.shapeType.Circle)
        //    {
        //        SFML.Graphics.CircleShape shape = new SFML.Graphics.CircleShape(50);
        //        wind.Draw(shape);
        //    }
        //}
    }
}
