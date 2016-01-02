using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Input
{
    public interface IDevice
    {
        float GetAxis(string axisName);
        bool hasAxis(string axisName);
        bool GetButton(string buttonName);
    }
}
