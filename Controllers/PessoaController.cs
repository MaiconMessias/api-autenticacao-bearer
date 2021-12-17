using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_autenticacao_bearer.Controllers
{
    [ApiController]
    [Route("v1")]
    public class PessoaController
    {
        [HttpGet]
        [Route("autenticacao")]
        [Authorize]
        public string TesteAutenticacao(){
             return "Usuário autenticado";   
        } 

    }
}