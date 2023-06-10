using System;
using System.Collections;
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
    public class IngredientController : ControllerBase
    {
        // GET: api/Ingredient
        [HttpGet]
        public async Task<ActionResult<IList<Ingredient>>> Get()
        {
            return Ok((await dao.RetornarTodosAsync()).ToDO());
        }

        // GET: api/Ingredient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ingredient>> GetPorId(string id)
        {
            var objeto = await dao.RetornarPorIdAsync(id);

            if (objeto == null)
                return NotFound();
            
            return Ok(objeto.ToDO());
        }

        // POST: api/Ingredient
        [HttpPost]
        public async Task<ActionResult<FoodDO>> Post(Ingredient objDO)
        {
            if (objDO == null)
                return Problem("O Ingrediente que você está tentando inserir está nulo.");

            var objeto = await objDO.ToModel();

            await dao.InserirAsync(objeto);

            objDO = objeto.ToDO();

            return CreatedAtAction(nameof(GetPorId), new { id = objDO.Id }, objDO);
        }
        
        // GET: api/Ingredient/populate
        [HttpGet("populate")]
        public async Task<ActionResult<FoodDO>> Populate()
        {
            var ingredients = new string[] { "Arroz", "Feijão", "Carne", "Salada", "Batata Frita", "Macarrão", "Frango", "Peixe", "Ovo", "Farofa" };
            var weights = new double[] { 0.2, 0.8, 0.3, 0.2, 0.2, 0.1, 0.4, 0.2, 0.1, 0.2 };
            int index = 0;
            foreach (var ing in ingredients)
            {
                var objeto = new Ingredient
                {
                    Name = ing,
                    Weight = weights[index]
                };
                await dao.InserirAsync(objeto);
                index++;
            }
            return Ok();
        }

        // PUT: api/Ingredient/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, Ingredient novoIngredient)
        {
            if (id != novoIngredient.Id)
                return Problem("Como você pode me enviar um id na rota diferente do id do objeto?");
                //return BadRequest();
            
            try
            {
                await dao.AlterarAsync(await novoIngredient.ToModel());
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Ingredient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await dao.ExcluirAsync(id);
            
            return NoContent();
        }

        private IngredientDAO dao = new IngredientDAO();
    }
}