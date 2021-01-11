using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Libreria.Modelo;
namespace ServicioWeb.WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        BibliotecaVirtualConnection BD = new BibliotecaVirtualConnection();
        public IEnumerable<usuario> Get()
        {
            var listado = BD.usuario.ToList();
            return listado;
        }
    }
}
