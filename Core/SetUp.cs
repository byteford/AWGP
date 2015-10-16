using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core
{
    public class SetUp
    {
        public static void Init()
        {
            try
            {
                IO.LoadFromFile.LoadFile("GameObject");
            }
            catch (FileNotFoundException e)
            {
                IO.LoadFromFile.SaveFile("GameObject");
                IO.LoadFromFile.LoadFile("GameObject");
            }
           new Managers.ModuleManager();
        }
    }
}
