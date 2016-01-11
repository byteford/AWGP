using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.SFMLSound;
namespace BlinkByte.LewisGame
{
    public class GameComp : BlinkByte.Core.Component.Component
    {
        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            
        }

        public override void Update()
        {
            if (BlinkByte.Input.Input.ButtonDown("d"))
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).AddForce("d", new Vector2(0.001f, 0));

            
            }
            else
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).RemoveForce("d", new Vector2());
            }
            if (Input.Input.ButtonDown("s"))
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).AddForce("s", new Vector2(0.00f, 0.001f));
            }
            else
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).RemoveForce("s", new Vector2());
            }
            if (BlinkByte.Input.Input.ButtonDown("w"))
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).AddForce("w", new Vector2(0.00f, -0.001f));
            }
            else
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).RemoveForce("w", new Vector2());
            }
            if (Input.Input.ButtonDown("a"))
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).AddForce("a", new Vector2(-0.001f, 0));
            }
            else
            {
                (gameObject.getComponent<BlinkByte.Physics.RidgedBodyComp>() as Physics.RidgedBodyComp).RemoveForce("a", new Vector2());
            }

            base.Update();
        }

    }
}
