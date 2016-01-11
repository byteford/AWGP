using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlinkByte.Core.Module;
using BlinkByte.Core;

namespace BlinkByte.GraceGame
{
    public class Core : BlinkByte.Core.Module.IModule
    {
        Random en = new Random();
        List<GameObject> enimies = new List<GameObject>();
        bool run = false;
        public ModuleType GetModuleType()
        {
            return (ModuleType)4;
        }

        public void Init()
        {
        }

        public void Update()
        {
            if (!run)
            {
                AddEnimies();
                    run = true;
            }
        }
        public void AddEnimies()
        {
            int randEnimiesAmount = en.Next(3, 10);
           
            for (int i = 0; i < randEnimiesAmount; i++)
            {
                GameObject go = GameObject.InstansateNew("EnemySprite");
                go.AddComponent<BlinkByte.SFMLGraphics.SFMLSprite2DComp>().TextureName = "Enemy.png";
                go.AddComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>();
                (go.getComponent<BlinkByte.Core.Component.Transform>() as BlinkByte.Core.Component.Transform).Position = new Vector2(250, 250);
                go.AddComponent<BlinkByte.StandardPhysics.StanBoundingBox>().SetMinMax(new Vector2(0, 0), new Vector2(64, 64));


                (go.getComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>() as BlinkByte.StandardPhysics.StanRidgedBodyComp).drag = 1;
                (go.getComponent<BlinkByte.StandardPhysics.StanRidgedBodyComp>() as BlinkByte.StandardPhysics.StanRidgedBodyComp).SetVelocity(new Vector2(0.1f, 0.2f));
                go.Start();
                BlinkByte.Core.Scene.currentScene.addGameObject(go);
                
                enimies.Add(go);
            }
        }
    }
}
