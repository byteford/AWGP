using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.Utilitys;
namespace BlinkByte.Physics
{
    public class RidgedBodyComp : BlinkByte.Core.Component.Component
    {
        public Vector2 force;
        public CollisionComp collider;

        public void AddForce(Vector2 force)
        {
            this.force += force;
        }

        public Vector2 GetForce()
        {
            return force;
        }

        public void SetForce(Vector2 setForce)
        {
            force = setForce;
        }

        public override void Update()
        {
            if (collider.CollisionCheck())
            {
                Console.WriteLine("Collided!");
            }
            base.Update();
        }

        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            collider = gameObject.getComponent<CollisionComp>() as CollisionComp;
        }
    }
}
