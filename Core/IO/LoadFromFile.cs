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
            TextReader reader;
            try
            {
                //serializer = new XmlSerializer(typeof(T));

                reader = new StreamReader(filename + ".xml");
                T temp = (T)GetSerializer<T>().Deserialize(reader);
                //x.Serialize(Console.Out, temp);
                reader.Close();
                // file.LoadXml(filename + ".xml");
                return temp;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("cant find: " + filename);
                //Console.WriteLine(e);
                throw;
            }
            catch (FileLoadException)
            {
                Console.WriteLine("file loaded fail " + filename);
                throw;
            }
            
        }
        
        public static void SaveFile<T>(string filename, T obj)
        {
            
           try {
               //serializer = new XmlSerializer(typeof(T));
                TextWriter writer = new StreamWriter(filename + ".xml",false);
                GetSerializer<T>().Serialize(writer, obj);
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
        public static bool LoadModules(string filename)
        {
            try
            {
                string ass;
                string mod;

                StreamReader file = new StreamReader(filename + ".module");

                while((ass = file.ReadLine()) != null && ass != "")
                {
                    mod = file.ReadLine();
                    Managers.ModuleManager.instance.AddManager(ass, mod);
                }

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool saveModules(string filename)
        {
            try
            {
                StreamWriter file = new StreamWriter(filename + ".module",false);
                foreach (var mod in Core.Managers.ModuleManager.instance.modules.Keys) {
                    file.WriteLine(mod.Module.Name);
                    file.WriteLine(Managers.ModuleManager.instance.modules[mod].GetType().ToString());
                }
                file.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
