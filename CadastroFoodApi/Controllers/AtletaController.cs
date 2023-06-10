using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadastroFoodApi.Models;
using CadastroFoodApi.Controllers.Extensoes;
using CadastroFoodDll.DOs;
using CadastroFoodApi.DAOs;

namespace CadastroFoodApi.Controllers
{
        [ApiController]
    [Route("api/[controller]")]
    public class FoodController : ControllerBase
    {
        // GET: api/Food
        [HttpGet]
        public async Task<ActionResult<IList<FoodDO>>> Get()
        {
            return Ok((await dao.RetornarTodosAsync()).ToDO());
        }

        // GET: api/Food/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FoodDO>> GetPorId(string id)
        {
            var objeto = await dao.RetornarPorIdAsync(id);

            if (objeto == null)
                return NotFound();
            
            return Ok(objeto.ToDO());
        }

        // POST: api/Food
        [HttpPost]
        public async Task<ActionResult<FoodDO>> Post(FoodDO objDO)
        {
            if (objDO == null)
                return Problem("O Food que você está tentando inserir está nulo.");

            var objeto = await objDO.ToModel();

            await dao.InserirAsync(objeto);

            objDO = objeto.ToDO();

            return CreatedAtAction(nameof(GetPorId), new { id = objDO.Id }, objDO);
        }

        // PUT: api/Food/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, FoodDO novoFoodDO)
        {
            if (id != novoFoodDO.Id)
                return Problem("Como você pode me enviar um id na rota diferente do id do objeto?");
                //return BadRequest();
            
            try
            {
                await dao.AlterarAsync(await novoFoodDO.ToModel());
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Food/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await dao.ExcluirAsync(id);
            
            return NoContent();
        }

        private FoodDAO dao = new FoodDAO();
    }
}