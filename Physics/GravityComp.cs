using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;

namespace BlinkByte.Physics
{
    public class GravityComp : BlinkByte.Core.Component.Component , BlinkByte.Physics.ITriggable
    {
        public void OnTrigger(object[] objs)
        {
            Console.WriteLine("tigger");
        }

        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            (gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp).AddForce("Gravity", new Vector2(0,0.01f));
        }
    }
}
