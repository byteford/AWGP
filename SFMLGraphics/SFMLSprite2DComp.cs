using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Utilitys;
namespace BlinkByte.SFMLGraphics
{
    public class SFMLSprite2DComp: BlinkByte.Graphics.Componates.Sprite2DComp
    {
        SFML.Graphics.Sprite SFMLShape;

        public SFMLSprite2DComp():base(){
            SFMLShape = new SFML.Graphics.Sprite();
            texture = new Texture();

                LoadTexture(TextureName);
            
        }
        public override void Draw()
        {
            SFMLShape.Color = getColor().convert();
            SFMLShape.Texture = (texture.getFile() as SFML.Graphics.Texture);
            if (gameObject.GetTransform() != null)
                SFMLShape.Position = gameObject.GetTransform().Position.convert();
            WindowManager.getInstance().getRenderWin().Draw(SFMLShape);
        }
        public override void LoadTexture(string fileName)
        {
            if (TextureName != null)
            {
                texture.loadTexture(fileName);
            }
            base.LoadTexture(fileName);
        }
    }
}
