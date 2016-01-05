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
        Vector2 totalOffset;
        public override void CollisionCheck()
        {
            foreach( var go in BlinkByte.Core.Scene.currentScene.GameObjects.Where(x => x.getComponent<StanCircleBounding>() != null))
            {
                otherObj = go.getComponent<StanCircleBounding>() as StanCircleBounding;
                totalRadius = radius + otherObj.radius;
                totalOffset = offset - otherObj.offset;
                if((totalOffset.X * totalOffset.X) + (totalOffset.Y * totalOffset.Y) < totalRadius * totalRadius)
                {

                }
                else
                {

                }
            }
            base.CollisionCheck();
        }
    }
}
