using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public enum shapeType
    {
        Circle,
        Square,
        Sprite
    }
    public class Shape2DComp: BlinkByte.Graphics.Componates.GraphicsComp
    {
        
        public Colour color;
        public shapeType shape;
        public Shape2DComp()
        {
            ShapeManager.inst.RegisterComp(this);
        }
        public virtual void Draw() { }
        public virtual void changeColor(Colour newcolor)
        {
            color = newcolor;
        }
        public virtual Colour getColor()
        {
            return color;
        }
    }

}
