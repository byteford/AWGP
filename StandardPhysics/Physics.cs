using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Physics;
using BlinkByte.Utilitys;

namespace BlinkByte.StandardPhysics
{
    public class Physics : BlinkByte.Physics.IPhysics
    {
        public List<CollisionComp> colliders = new List<CollisionComp>();
        public static Physics instance;
        bool result, colCek;
        float totalRadius;
        Vector2 aObj, bObj;

        public Core.Module.ModuleType GetModuleType()
        {
            return Core.Module.ModuleType.Physics;
        }
        public void Init()
        {
            instance = this;
            Console.WriteLine("Physics Started");
        }

        public virtual void Update()
        {
           
        }
       
        public void AddCollider(CollisionComp collider)
        { 
            colliders.Add(collider);
        }

        public bool CollisionCheck()
        {
            for (int i = 0; i< colliders.Count; i++)
            {
                for (int j = i+1; j < colliders.Count; j++)
                {
                    colCek = false;
                    switch (colliders[i].collType)
                    {
                        case colliderType.box:
                            switch (colliders[j].collType)
                            {
                                case colliderType.box:

                                    colCek = boxColChek(colliders[i] as BoundingBoxComp, colliders[j] as BoundingBoxComp);
                                    break;
                                case colliderType.circle:
                                    colCek = cirlBoxChek(colliders[j] as CircleBoundingComp, colliders[i] as BoundingBoxComp);
                                    break;
                                case colliderType.none:
                                    break;
                            }
                            break;
                        case colliderType.circle:
                            switch (colliders[j].collType)
                            {
                                case colliderType.box:
                                    colCek = cirlBoxChek(colliders[i] as CircleBoundingComp, colliders[j] as BoundingBoxComp);
                                    break;
                                case colliderType.circle:
                                    colCek = cirlColChek(colliders[i] as CircleBoundingComp, colliders[j] as CircleBoundingComp);
                                    break;
                                case colliderType.none:
                                    break;
                            }
                            break;
                        case colliderType.none:
                            break;
                    }
                    if (colCek)
                    {
                        ResolveCollision(colliders[i], colliders[j]);
                    }
                }
            }
            return result;
        }

        public bool cirlColChek(CircleBoundingComp colliderA, CircleBoundingComp colliderB)
        {
            result = false;
                totalRadius = colliderA.radius + colliderB.radius;
                aObj = colliderA.gameObject.GetTransform().Position + colliderA.offset;
                bObj = colliderB.gameObject.GetTransform().Position + colliderB.offset;
                result = totalRadius > (Math.Pow((aObj.X + bObj.X), 2) - Math.Pow((aObj.Y + bObj.Y), 2));
            
            return result;
        }

        public bool boxColChek(BoundingBoxComp colliderA, BoundingBoxComp colliderB)
        {
            return true;
        }

        public bool cirlBoxChek(CircleBoundingComp circColliderA, BoundingBoxComp boxColliderB)
        {
            return true;
        }
        public void ResolveCollision(CollisionComp colliderA, CollisionComp colliderB)
        {
            RidgedBodyComp objectA = colliderA.gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp;
            RidgedBodyComp objectB = colliderB.gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp;
            Vector2 relVelocity = objectB.GetVelocity() - objectA.GetVelocity();
            Vector2 normal = relVelocity.Normalise();

            float velByNormal = relVelocity.DotProduct(normal);

            //do not resolve if moving away from each other
            if (velByNormal < 0)
            {
                return;
            }

            float epsilon = Math.Min(objectA.restitution, objectB.restitution);

            float impulseScalar = -(1 + epsilon) * velByNormal;

            impulseScalar /= 1 / objectA.GetMass() + 1 / objectB.GetMass();

            Vector2 impulse = impulseScalar * normal;
            //objectA.RemoveForce(1 / objectA.mass * impulse);
            //objectB.AddForce(1 / objectB.mass * impulse);

            float mass_sum = objectA.GetMass() + objectB.GetMass() * 0.001f;
            float ratio = objectA.GetMass() / mass_sum;
            objectA.RemoveForce(ratio * impulse);

            ratio = objectB.GetMass() / mass_sum;
            objectB.AddForce(ratio * impulse);
        }
    }
}
