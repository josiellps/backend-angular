using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace backEnd_lista_telefonica_angular.Models
{
    public class Contatos
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Selecionado { get; set; }

        public Operadoras Operadora { get; set; }
    }
}