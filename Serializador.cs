using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace VoosApp
{
    public static class Serializador
    {
        // Serializa��o para JSON (substituto do BinaryFormatter)
        public static void SerializeToJson(Movimento movimento, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(movimento, options);
            File.WriteAllText(filePath, jsonString);
        }

        // Desserializa��o de JSON
        public static Movimento DeserializeFromJson(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Movimento>(jsonString);
        }

        // Serializa��o para XML
        public static void SerializeToXml(Movimento movimento, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Movimento));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, movimento);
            }
        }

        // Desserializa��o de XML
        public static Movimento DeserializeFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Movimento));
            using (StreamReader reader = new StreamReader(filePath))
            {
                return (Movimento)serializer.Deserialize(reader);
            }
        }
    }
}
