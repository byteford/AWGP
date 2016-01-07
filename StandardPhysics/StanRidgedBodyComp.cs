using BlinkByte.Physics;
using BlinkByte.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class StanRidgedBodyComp : BlinkByte.Physics.RidgedBodyComp
    {
        public override void Update()
        {
            CollisionComp otherCollider;
            if (collider.CollisionCheck(out otherCollider))
            {
                Console.WriteLine("Collided!");
            }
            gameObject.GetTransform().Position += velocity;
            base.Update();
        }

        public override void ResolveCollision(CollisionComp colliderA, CollisionComp colliderB)
        {
            RidgedBodyComp objectA = colliderA.gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp;
            RidgedBodyComp objectB = colliderB.gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp;
            Vector2 relVelocity = objectB.GetVelocity() - objectA.GetVelocity();
            Vector2 normal = relVelocity.Normalise();
            float velByNormal = relVelocity.DotProduct(normal);

            //do not resolve if moving away from each other
            if (velByNormal > 0)
            {
                return;
            }

            float epsilon = Math.Min(objectA.restitution, objectB.restitution);

            float impulseScalar = -(1 + epsilon) * velByNormal;

            impulseScalar /= 1 / objectA.GetMass() + 1 / objectB.GetMass();

            Vector2 impulse = impulseScalar * normal;
            //objectA.RemoveForce(1 / objectA.mass * impulse);
            //objectB.AddForce(1 / objectB.mass * impulse);

            float mass_sum = objectA.GetMass() + objectB.GetMass();
            float ratio = objectA.GetMass() / mass_sum;
            objectA.RemoveForce(ratio * impulse);

            ratio = objectB.GetMass() / mass_sum;
            objectB.AddForce(ratio * impulse);
        }
    }
}
