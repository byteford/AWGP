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
        public static T LoadFile<T>(string filename)
        {
           
            try {
                XmlSerializer x = new XmlSerializer(typeof(T));

                TextReader reader = new StreamReader(filename + ".xml");
                T temp = (T)x.Deserialize(reader);
                //x.Serialize(Console.Out, temp);
                reader.Close();
                // file.LoadXml(filename + ".xml");
                return temp;
            }catch(FileNotFoundException )
            {
                Console.WriteLine("cant find: " + filename);
               
                //Console.WriteLine(e);
                throw;
            }
            
        }
        
        public static void SaveFile<T>(string filename, T tempGO)
        {
            
        //    try {
                XmlSerializer x = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(filename + ".xml");
                x.Serialize(writer, tempGO);
                writer.Close();
          /*  }
            catch (Exception e)
            {
                Console.WriteLine(e);
              
            }*/
            
        }
        /*public static void SaveFile(string filename, Scene scene)
        {
            XmlSerializer x = new XmlSerializer(typeof(Scene));
            TextWriter writer = new StreamWriter(filename + ".xml");
            x.Serialize(writer, scene);
        }*/
    }
}
