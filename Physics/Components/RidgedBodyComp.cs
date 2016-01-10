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
        public Vector2 velocity = new Vector2();
        public CollisionComp collider;
        public float mass =10;
        public float restitution = 1;
        public bool startCollision = true;
        public bool isTrigger = false;

        protected Dictionary<string, Vector2> forces = new Dictionary<string, Vector2>();

        public void AddForce(string forceName, Vector2 force)
        {
            if (forces.ContainsKey(forceName))
            {
                return;
            }
            forces.Add(forceName, force);
            //this.velocity += force;
        }
        public void RemoveForce(string forceName, Vector2 force)
        {
            if (forces.ContainsKey(forceName))
            {
                forces.Remove(forceName);
            }
            
            //this.velocity -= force;
        }
        public Vector2 GetVelocity()
        {
            return velocity;
        }

        public void SetVelocity(Vector2 setForce)
        {
            velocity = setForce;
        }

        public void SetMass(float setMass)
        {
            mass = setMass;
        }

        public float GetMass()
        {
            return mass;
        }

        public float GetInvMass()
        {
            if (GetMass() == 0)
            {
                return 0;
            }
            return 1/GetMass();
        }

        public void SetRestitution(float setRes)
        {
            restitution = setRes;
        }

        public float GetRestitution()
        {
            return restitution;
        }

        public override void Update()
        {
            base.Update();
        }

        public virtual void ResolveCollision(CollisionComp colliderA, CollisionComp colliderB)
        {
            
        }

        public override void Start(GameObject gameObject)
        {
            base.Start(gameObject);
            collider = gameObject.getComponent<CollisionComp>() as CollisionComp;
        }
    }
}
