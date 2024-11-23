using System;

namespace VoosApp
{
    public class Voo
    {
        public string Codigo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Horario { get; set; }
        public string Compania { get; set; }
        public bool Operando { get; set; } // True para 'T', False para 'F'
    }
}
