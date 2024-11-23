using System;

namespace VoosApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Movimento
            Movimento movimento = new Movimento();
            movimento.Voos.Add(new Voo
            {
                Codigo = "VG456",
                Origem = "CGH",
                Destino = "POA",
                Horario = "14:35",
                Compania = "Varig",
                Operando = true
            });

            movimento.Voos.Add(new Voo
            {
                Codigo = "AZ002",
                Origem = "VCP",
                Destino = "SSA",
                Horario = "18:00",
                Compania = "Azul",
                Operando = false
            });

            // Serializando em JSON
            string jsonPath = "movimento.json";
            Serializador.SerializeToJson(movimento, jsonPath);
            Console.WriteLine("Movimento serializado em JSON!");

            // Desserializando do JSON
            Movimento movimentoJson = Serializador.DeserializeFromJson(jsonPath);
            Console.WriteLine($"Total de voos desserializados do JSON: {movimentoJson.Voos.Count}");

            // Serializando em XML
            string xmlPath = "movimento.xml";
            Serializador.SerializeToXml(movimento, xmlPath);
            Console.WriteLine("Movimento serializado em XML!");

            // Desserializando do XML
            Movimento movimentoXml = Serializador.DeserializeFromXml(xmlPath);
            Console.WriteLine($"Total de voos desserializados do XML: {movimentoXml.Voos.Count}");
        }
    }
}
