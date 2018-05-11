using backEnd_lista_telefonica_angular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;

namespace backEnd_lista_telefonica_angular.Controllers
{
    [RoutePrefix("api/Operadoras")]
    public class OperadoraController : ApiController
    {
        [Route("Listar")]
        [HttpGet]
        public List<Operadoras> ListarOperadoras()
        {
            return new List<Operadoras>(){
                new Operadoras()  { Nome= "Oi", Codigo= 14, Categoria= "Celular" },
                new Operadoras() { Nome= "Vivo", Codigo= 15, Categoria= "Celular" },
                new Operadoras() { Nome= "Tim", Codigo= 41, Categoria= "Celular" },
                new Operadoras() { Nome= "GVT", Codigo= 25, Categoria= "Fixo" },
                new Operadoras() { Nome= "Embratel", Codigo= 41, Categoria= "Fixo" }
                };
        }
    }
}
