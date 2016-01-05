using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Input
{
    public static class Input
    {
        private static Dictionary<string,IDevice> _devices;
        public static float GetAxis(string axisName)
        {
            IDevice temp = GetDevices().First(x => x.hasAxis(axisName));
            if (temp != null)
                return temp.GetAxis(axisName);
            return 0;

        }
        public static IDevice addDevice(string DeviceName, IDevice device)
        {
            addToDiconary(DeviceName, device);
            return device;
        }
        public static IDevice GetDevice(string deviceName)
        {
            IDevice temp;
            GetFromDiconary(deviceName, out temp);
            return temp;
            
        }
        public static List<IDevice> GetDevices()
        {
            return _devices.Values.ToList();
        }
        private static void addToDiconary(string DeviceName, IDevice device)
        {
            InitDiconary();
            _devices.Add(DeviceName, device);
        }
        private static bool GetFromDiconary(string DeviceName, out IDevice device)
        {
            if (!Diconarystarted())
            {
                device = null;
                return false;
            }else if (_devices.ContainsKey(DeviceName))
            {
                device = _devices[DeviceName];
                return true;
            }
            else
            {
                device = null;
                return false;
            }
        }
        private static void InitDiconary()
        {
            if (Diconarystarted())
            {
                _devices = new Dictionary<string, IDevice>();
            }
        }
        private static bool Diconarystarted()
        {
            return !(_devices == null);
        }
    }
}
