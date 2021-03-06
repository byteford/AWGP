﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Input
{
    public interface IDevice
    {
        bool hasButton(string button);
        bool GetButton(string button);
        IDevice addButton(string button, object buttonObj);
        IDevice addButton(string button, int buttonint);
    }
}
