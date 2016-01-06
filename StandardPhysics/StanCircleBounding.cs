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
            foreach (var go in BlinkByte.Core.Scene.currentScene.GameObjects.Where(x => x.getComponent<StanCircleBounding>() != null))
            {
                otherObj = go.getComponent<StanCircleBounding>() as StanCircleBounding;
                totalRadius = radius + otherObj.radius;
                Vector2 aObj = gameObject.GetTransform().Position + offset;
                Vector2 bObj = go.GetTransform().Position + otherObj.offset;
                return totalRadius < (Math.Pow((aObj.X + bObj.X), 2) + Math.Pow((aObj.Y + bObj.Y), 2));

                base.CollisionCheck();
            }
            return false;
        }
    }
}
