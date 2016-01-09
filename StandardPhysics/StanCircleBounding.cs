using BlinkByte.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;

namespace BlinkByte.StandardPhysics
{
    public class StanCircleBounding : BlinkByte.Physics.CircleBoundingComp
    {
        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            Physics.instance.AddCollider(this);
        }
    }
}
