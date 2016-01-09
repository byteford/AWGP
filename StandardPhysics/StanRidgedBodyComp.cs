﻿using BlinkByte.Physics;
using BlinkByte.Utilitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.StandardPhysics
{
    public class StanRidgedBodyComp : BlinkByte.Physics.RidgedBodyComp
    {
        public override void Update()
        {
            gameObject.GetTransform().Position += velocity * Time.deltaTime;
            
            base.Update();
        }
    }
}
