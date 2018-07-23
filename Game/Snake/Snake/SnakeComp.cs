using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core;
using BlinkByte.Core.Component;
using BlinkByte.Input;
namespace BlinkByte.Snake
{
    public class SnakeComp: Component
    {
        public enum dir
        {
            up,
            down,
            left,
            right,
        }
        dir direction = dir.right;
        public override void Update()
        {
            if (Input.Input.ButtonDown("s")){
                direction = dir.down;
            }
            if (Input.Input.ButtonDown("w"))
            {
                direction = dir.up;
            }
            if (Input.Input.ButtonDown("d"))
            {
                direction = dir.right;
            }
            if (Input.Input.ButtonDown("a"))
            {
                direction = dir.left;
            }

            switch (direction)
            {
                case dir.up:
                        gameObject.GetTransform().Position.Y = gameObject.GetTransform().Position.Y - 0.05f; 
                    break;
                case dir.down:
                    gameObject.GetTransform().Position.Y = gameObject.GetTransform().Position.Y + 0.05f;
                    break;
                case dir.left:
                    gameObject.GetTransform().Position.X = gameObject.GetTransform().Position.X - 0.05f;
                    break;
                case dir.right:
                    gameObject.GetTransform().Position.X = gameObject.GetTransform().Position.X + 0.05f;
                    break;
            }
            base.Update();
        }
    }
}
