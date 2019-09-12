using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Pessoa
    {
        public int CdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DtNasc { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public bool RecebeEmail { get; set; }
        public bool RecebeSMS { get; set; }

    }
}
