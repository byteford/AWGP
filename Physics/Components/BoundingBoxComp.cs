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
        public Vector2 min = new Vector2();
        public Vector2 max = new Vector2();

        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            collType = colliderType.box;
        }

        public void SetMinMax(Vector2 min, Vector2 max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
