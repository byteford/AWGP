using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    class MovementComp : BlinkByte.Physics.MovementComp
    {
        public override void Update()
        {
            gameObject.GetTransform().Position += force;
            base.Update();
        }
    }
}
