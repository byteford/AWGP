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

        public override bool CollisionCheck(out BlinkByte.Physics.CollisionComp otherCollider)
        {
            bool result;
            foreach (var go in BlinkByte.Core.Scene.currentScene.GameObjects.Where(x => x.getComponent<StanCircleBounding>() != null))
            {
                otherObj = go.getComponent<StanCircleBounding>() as StanCircleBounding;
                totalRadius = radius + otherObj.radius;
                Vector2 aObj = gameObject.GetTransform().Position + offset;
                Vector2 bObj = go.GetTransform().Position + otherObj.offset;
                result = totalRadius > (Math.Pow((aObj.X + bObj.X), 2) + Math.Pow((aObj.Y + bObj.Y), 2));
                if (result)
                {
                    otherCollider = otherObj;
                    return true;
                }   
            }
            result = base.CollisionCheck(out otherCollider);
            return result;
        }
    }
}
