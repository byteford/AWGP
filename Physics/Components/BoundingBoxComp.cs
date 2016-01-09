using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.Utilitys;

namespace BlinkByte.Physics
{
    public class BoundingBoxComp : CollisionComp
    {
        public Vector2 min;
        public Vector2 max;

        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            collType = colliderType.box;
        }
    }
}
