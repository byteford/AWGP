using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlinkByte.Core.Component
{
    [System.Serializable]
    public class FileOutput : Component
    {
        public string toOutput = "Update";
        public override void Update()
        {
           Console.WriteLine(toOutput);
        }
    }
}
