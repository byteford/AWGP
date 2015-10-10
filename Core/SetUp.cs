using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core
{
    public class SetUp
    {
        public static void Init()
        {
             IO.LoadFromFile.LoadFile("GameObject");
            //IO.LoadFromFile.SaveFile("GameObject");
           new Managers.ModuleManager();
        }
    }
}
