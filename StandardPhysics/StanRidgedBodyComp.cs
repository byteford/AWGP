using BlinkByte.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class StanRidgedBodyComp : BlinkByte.Physics.RidgedBodyComp
    {
        float drag = 0.999f;
        Vector2 oldVelocity = new Vector2();
        public override void Update()
        {
            foreach(var key in forces.Keys)
            {
               velocity += forces[key] ;
            }
            velocity = velocity * drag;
            gameObject.GetTransform().Position.Y += ((velocity.Y + oldVelocity.Y) * (0.5f * Time.deltaTime));
            gameObject.GetTransform().Position.X += ((velocity.X + oldVelocity.X) * (0.5f * Time.deltaTime));
            oldVelocity = velocity;
            //gameObject.GetTransform().Position += velocity * Time.deltaTime;           
            base.Update();
        }
    }
}
