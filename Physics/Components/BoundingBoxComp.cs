using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;

namespace BlinkByte.Physics
{
    public class BoundingBoxComp : CollisionComp
    {
        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            collType = colliderType.box;
        }
    }
}
