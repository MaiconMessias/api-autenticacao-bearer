using System.Threading.Tasks;
using api_autenticacao_bearer.Models;
using api_autenticacao_bearer.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_autenticacao_bearer.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController
    {
       [HttpPost]
       [Route("obtertoken")] 
       public async Task<ActionResult<string>> ObterTokenAsync([FromBody] Usuario usuario)
       {
            /* código para verificar se o usuário existe
                ....
            */
            
            TokenGenerator tokenGenerator = new TokenGenerator();               
            string token = tokenGenerator.GenerateToken();

            await Task.Delay(100);

            return token;
       }

    }
}