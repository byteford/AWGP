using BlinkByte.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class StanBoundingBox : BlinkByte.Physics.BoundingBoxComp
    {
        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            Physics.instance.AddCollider(this);
        }
    }
}
