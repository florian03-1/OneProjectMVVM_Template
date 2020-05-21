using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OneProjectMVVM_Template.Context
{
    public class DataContext
    {
        private DataContext()  // Damit kein Objekt angelegt werden kann
        {
        }
        public static DataContext Instance { get; } = new DataContext();

        //Hier die Methoden laden,speicher, etc.
        //Und die Eigenschaften, die gespeichert werden sollen
    }



    //XML-Serializer
    internal static class Serializer
    {
        public static void SaveXML<T>(string filename, T serializedObject)
        {
            try
            {
                using (var fs = new FileStream(filename, FileMode.Create))
                {
                    new XmlSerializer(typeof(T)).Serialize(fs, serializedObject);
                }
            }
            catch
            {
                throw; //Fehler hier ausgeben
            }           
        }
        public static T LoadXML<T>(string filename)
        {         
            try
            {
                using (var fs = new FileStream(filename, FileMode.Open))
                {
                    return (T)new XmlSerializer(typeof(T)).Deserialize(fs);
                }
            }
            catch
            {
                throw; //Fehler hier ausgeben
            }
        }
    }
}
