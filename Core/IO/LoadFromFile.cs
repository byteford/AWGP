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
        /// <summary>
        /// Deserializes an xml file in to a class
        /// </summary>
        /// <typeparam name="T">The file to deserialize the xml in to </typeparam>
        /// <param name="filename">The relitive path of the file</param>
        /// <returns></returns>
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
        
        /// <summary>
        /// saves an object as a xml file
        /// </summary>
        /// <typeparam name="T">object type</typeparam>
        /// <param name="filename">the relitave location to save the file</param>
        /// <param name="obj">the object to save</param>
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
        /// <summary>
        /// Get an xmlSerializer for a given type (code found, not 100% sure how it works, though could work it out it had enough time)Component.Componet might need to be T, but it works for now
        /// </summary>
        /// <typeparam name="T">The type of the file to serialize</typeparam>
        /// <returns></returns>
        public static XmlSerializer GetSerializer<T>()
        {
            var lListOfComp = (from lAssembly in AppDomain.CurrentDomain.GetAssemblies()
                             from lType in lAssembly.GetTypes()
                             where typeof(Component.Component).IsAssignableFrom(lType)
                             select lType).ToArray();
            return new XmlSerializer(typeof(T), lListOfComp);
        }
        /// <summary>
        /// Load a file that states which modules to load.
        /// Then loads the modules
        /// </summary>
        /// <param name="filename"> The relitive location of the file</param>
        /// <returns></returns>
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
        /// <summary>
        /// saves loaded modules to a file loction
        /// </summary>
        /// <param name="filename">relitave path to save to,</param>
        /// <returns></returns>
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
