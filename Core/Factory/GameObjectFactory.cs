using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Factory
{
    public class GameObjectFactory: IFactory
    {
        public static GameObject makeGameObject(string name)
        {
            GameObject tempGO = IO.LoadFromFile.LoadFile(name) as GameObject;

            return tempGO;
        }
    }
}
