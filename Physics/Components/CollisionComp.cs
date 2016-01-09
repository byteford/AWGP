using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.Utilitys;

namespace BlinkByte.Physics

{
   public enum colliderType
    {
        none, 
        box,
        circle
    }

    public class CollisionComp : BlinkByte.Core.Component.Component
    {
        public Vector2 offset = new Vector2();
        public colliderType collType;

        public virtual bool CollisionCheck(out CollisionComp othercolider)
        {
            othercolider = null;
            return false;
        }
    }
}
