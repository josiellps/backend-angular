using backEnd_lista_telefonica_angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace backEnd_lista_telefonica_angular.Controllers
{
    [RoutePrefix("api/Contatos")]
    public class ContatoController : ApiController
    {
        // GET: Contato
        [Route("Listar")]
        public IEnumerable<Contatos> ListarContatos()
        {
            return new List<Contatos>() {
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false},
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false},
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false},
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false},
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false},
                new Contatos() { Nome = "Josiel", Telefone = "98251750" ,Selecionado = false}};
        }
    }
}