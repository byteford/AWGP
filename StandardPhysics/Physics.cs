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

        Vector2 minPosA, maxPosA, minPosB, maxPosB;
        float xAxisleft, xAxisRight, yAxisUp, yAxisDown, maxY, maxX;

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
            CollisionCheck();
        }
       
        public void AddCollider(CollisionComp collider)
        { 
            colliders.Add(collider);
        }

        public bool CollisionCheck()
        {
            for (int i = 0; i< colliders.Count; i++)
            {
                if (!(colliders[i].gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp).startCollision)
                {
                    continue;
                }
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
                        if ((colliders[i].gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp).isTrigger)
                        {
                            BlinkByte.Core.Scene.currentScene.RunMethodCall<BlinkByte.Physics.ITriggable>("OnTrigger", new object[] { colliders[j] });
                        }
                        else if((colliders[j].gameObject.getComponent<RidgedBodyComp>() as RidgedBodyComp).isTrigger)
                        {
                            BlinkByte.Core.Scene.currentScene.RunMethodCall<BlinkByte.Physics.ITriggable>("OnTrigger",new object[]{ colliders[i]});
                        }
                        else
                        {
                            ResolveCollision(colliders[i], colliders[j]);
                        }
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
                result = totalRadius > Math.Abs((Math.Pow((aObj.X + bObj.X), 2) - Math.Pow((aObj.Y + bObj.Y), 2)));
            
            return result;
        }

        public bool boxColChek(BoundingBoxComp colliderA, BoundingBoxComp colliderB)
        {
            result = false;
            minPosA = colliderA.min + colliderA.gameObject.GetTransform().Position;
            maxPosA = colliderA.max + colliderA.gameObject.GetTransform().Position;
            minPosB = colliderB.min + colliderB.gameObject.GetTransform().Position;
            maxPosB = colliderB.max + colliderB.gameObject.GetTransform().Position;

            if (maxPosA.X < minPosB.X || minPosA.X > maxPosB.X) 
            {
                return result;
            }
            if (maxPosA.Y < minPosB.Y || minPosA.Y > colliderB.max.Y)
            {
                return result;
            }
            return result = true;
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
            Vector2 tempnorm;//= (objectA.gameObject.GetTransform().Position - objectB.gameObject.GetTransform().Position).Normalise();
            //Console.WriteLine("X: " + tempnorm.X + " Y: " + tempnorm.Y);

            minPosA = (colliderA as BoundingBoxComp).min + colliderA.gameObject.GetTransform().Position;
            maxPosA = (colliderA as BoundingBoxComp).max + colliderA.gameObject.GetTransform().Position;
            minPosB = (colliderB as BoundingBoxComp).min + colliderB.gameObject.GetTransform().Position;
            maxPosB = (colliderB as BoundingBoxComp).max + colliderB.gameObject.GetTransform().Position;

            xAxisleft = minPosA.X - maxPosB.X;
            xAxisRight = maxPosA.X - minPosB.X;

            yAxisUp = minPosA.Y - maxPosB.Y;
            yAxisDown = maxPosA.Y - minPosB.Y;

            maxY = Math.Max(yAxisDown, yAxisUp);
            maxX = Math.Max(xAxisleft, xAxisRight);
            tempnorm = new Vector2(1, 1);
            if(maxY > maxX)
            {
                tempnorm.X = -1;
            }
            else
            {
                tempnorm.Y = -1;
            }

           // if (tempnorm.Y !=1)
           //     if (tempnorm.Y < 0 || tempnorm.Y > 0)
           // {
           //     tempnorm.Y = -1;
           // }
           // if(tempnorm.X != 1)
           //if (tempnorm.X < 0 || tempnorm.X > 0)
           // {
           //     tempnorm.X = -1;
           // }
            
            
            objectA.velocity.X = objectA.velocity.X * tempnorm.X;
            objectA.velocity.Y = objectA.velocity.Y * tempnorm.Y;
            /*  float epsilon = Math.Min(objectA.restitution, objectB.restitution);

              float impulseScalar = -(1 + epsilon) * velByNormal;

              impulseScalar /= objectA.GetInvMass() + objectB.GetInvMass();

              Vector2 impulse = impulseScalar * normal;

              float mass_sum = objectA.GetMass() + objectB.GetMass();
              float ratio = objectA.GetMass() / mass_sum;
              objectA.RemoveForce(ratio * impulse);

              ratio = objectB.GetMass() / mass_sum;
              objectB.AddForce(ratio * impulse);*/
        }
    }
}
