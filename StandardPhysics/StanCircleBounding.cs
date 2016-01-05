using BlinkByte.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class StanCircleBounding : BlinkByte.Physics.CircleBoundingComp
    {
        StanCircleBounding otherObj;
        float totalRadius;
        Vector2 distance;
        public override bool CollisionCheck()
        {
            foreach( var go in BlinkByte.Core.Scene.currentScene.GameObjects.Where(x => x.getComponent<StanCircleBounding>() != null))
            {
                otherObj = go.getComponent<StanCircleBounding>() as StanCircleBounding;
                totalRadius = radius + otherObj.radius;
                distance = gameObject.GetTransform().Position + offset - go.GetTransform().Position + otherObj.offset;
                if((totalOffset.X + totalOffset.X)^2 + (totalOffset.Y + totalOffset.Y)^2 < totalRadius * totalRadius)
                    //if (totalRadius > totalOffset)
                {
                    Console.WriteLine("Objects are colliding!");
                    return true;
                }
                else
                {
                    return false;
                }
            }           
            base.CollisionCheck();
            return false;
        }
    }
}
