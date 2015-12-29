using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Graphics.Componates
{
    public class Sprite2DComp: Shape2DComp
    {
        protected ITexture texture;
        protected string TextureName;
        public Sprite2DComp()
            : base()
        {
            shape = shapeType.Sprite;
        }
        public override void Draw() { }
        public virtual void LoadTexture(string fileName) { }
    }
}
