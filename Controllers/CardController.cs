using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vaivoaCard.Data;
using vaivoaCard.Models;

namespace vaivoaCard.Controllers
{
    [ApiController]
    //Rota Principal
    [Route("v1/cards")]
    public class CardController : ControllerBase
    {
        //Metodo GET para listar todos os cartões cadastrados
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Card>>> Get([FromServices] DataContext context)
        {
            var resultCards = await context.Cards.ToListAsync();
            return resultCards;
        }

        //Consulta filtrando pelo email informado mostrando em ordem de cadastro
        [HttpGet]
        [Route("{cardemail}")]
        public async Task<ActionResult<List<Card>>> GetByDesc([FromServices] DataContext context, string cardemail)
        {
            var resultCardEmail = await context.Cards
                .Where(x => x.CardEmail == cardemail)
                .OrderBy(x => x.CardId)
                .ToListAsync();
            return resultCardEmail;
        }

        //Metodo Post para cadastro de um novo cartão
        //Obs.: Ao executar informar apenas o campo email, os demais serão gerados automaticamente
        [HttpPost]
        [Route("")]
        public async Task <ActionResult <Card>> Post([FromServices] DataContext context, [FromBody]Card model)
        {
            if (ModelState.IsValid)
            {
                context.Cards.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}