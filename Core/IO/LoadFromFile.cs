using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlinkByte.Core.IO
{
    public class LoadFromFile
    {
        public static void LoadFile(string filename)
        {
            XmlDocument file = new XmlDocument();
            file.LoadXml(filename + ".xml");
            
        }
        public static void SaveFile(string filename )
        {
            XmlDocument file = new XmlDocument();

            XmlNode rootNode = file.CreateElement("GameObject");
            file.AppendChild(rootNode);

            
           // ComponateNode.InnerText = "Position";
           // rootNode.AppendChild(ComponateNode);


            file.Save(filename + ".xml");
            file.Save(Console.Out);
        }
    }
}
