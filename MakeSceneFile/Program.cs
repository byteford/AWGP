using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte;
using BlinkByte.Core;
namespace MakeSceneFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new BlinkByte.Core.Scene();
            GameObject go = GameObject.Instansate("GameObject");
            go.AddComponent<BlinkByte.Core.Component.Transform>();
            go.AddComponent<BlinkByte.Graphics.Componates.Shape2DComp>();
            scene.addGameObject(go);
            scene.saveToFile();
        }
    }
}
