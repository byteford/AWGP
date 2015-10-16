using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BlinkByte.Core.IO
{
    public class LoadFromFile
    {
        public static Object LoadFile(string filename)
        {
            try {
                XmlSerializer x = new XmlSerializer(typeof(GameObject));
                TextReader reader = new StreamReader(filename + ".xml");
                object temp = x.Deserialize(reader);
                x.Serialize(Console.Out, temp);
                // file.LoadXml(filename + ".xml");
                return temp;
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
            
        }
        
        public static void SaveFile(string filename, GameObject tempGO)
        {
           // GameObject tempGO = new GameObject();
           // Core.Component.Transform temp = new Component.Transform();
           // temp.Position.X = 10;
           // temp.Position.Y = 10;
           // temp.Position.Z = 20;
           // tempGO.components.Add(temp);
            XmlSerializer x = new XmlSerializer(typeof(GameObject));
            TextWriter writer = new StreamWriter(filename + ".xml");
            x.Serialize(writer,  tempGO);
            
        }
        public static void SaveScene(string filename, Scene scene)
        {
            XmlSerializer x = new XmlSerializer(typeof(Scene));
            TextWriter writer = new StreamWriter(filename + ".xml");
            x.Serialize(writer, scene);
        }
    }
}
