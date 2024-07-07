using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace BankingApp_20210884
{
    static public class PersistenceData
    {
        public static void SerializeToXmlFile<T>(List<T> data, string filepath)
        {
            using (var fileStream = new FileStream(filepath, FileMode.Create))
            {
                using (var writer = XmlDictionaryWriter.CreateTextWriter(fileStream))
                {
                    var serializer = new DataContractSerializer(typeof(List<T>));
                    serializer.WriteObject(writer, data);
                }
            }
        }

        public static void ValidateFilePersitence(string filepath) {
            
            var workingDirectory = Environment.CurrentDirectory;
            var file = $"{workingDirectory}\\{filepath}";
            var myFile = File.Exists(file);
            if (myFile == false) {
                var createdFile = File.Create(file);
                createdFile.Close();
            }
        }     

        public static List<T> DeserializeFromXmlFile<T>(string filepath)
        {
            ValidateFilePersitence(filepath);

            using (var fileStream = new FileStream(filepath, FileMode.Open))
            {
                if(fileStream.Length != 0){
                    using (var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas()))
                    {
                        var serializer = new DataContractSerializer(typeof(List<T>));
                        return (List<T>)serializer.ReadObject(reader, true);
                    }
                }
                return null;


            }
        }
    }
}
