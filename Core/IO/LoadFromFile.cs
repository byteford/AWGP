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
       static XmlSerializer serializer;
        public static T LoadFile<T>(string filename)
        {
           
            try {
                //serializer = new XmlSerializer(typeof(T));

                TextReader reader = new StreamReader(filename + ".xml");
                T temp = (T)GetSerializer<T>().Deserialize(reader);
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
            
           try {
               //serializer = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(filename + ".xml");
                GetSerializer<T>().Serialize(writer, tempGO);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
              
            }
            
        }
        public static XmlSerializer GetSerializer<T>()
        {
            var lListOfComp = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                             from lType in lAssembly.GetTypes()
                             where typeof(Component.Component).IsAssignableFrom(lType)
                             select lType).ToArray();
           
            return new XmlSerializer(typeof(T), lListOfComp);
        }
    }
}
