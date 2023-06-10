using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CadastroFoodApi.Models;
using CadastroFoodApi.Controllers.Extensoes;
using CadastroFoodApi.Controllers;
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
        
        // POST: api/Food/Save/Ingredients
        [HttpPost("Save/Ingredients")]
        public async Task<ActionResult<FoodIngredient>> SaveFoodIngredient(FoodIngredient objDO)
        {
            var objeto = await objDO.ToModel();

            await daoFI.InserirAsync(objeto);

            objDO = objeto.ToDO();
            
            Console.WriteLine(objDO.IdIngredient);

            return CreatedAtAction(nameof(GetPorId), new { id = objDO.Id }, objDO);
        }
        
        // GET: api/Food/Ingredients/5
        [HttpGet("Ingredients/{id}")]
        public async Task<ActionResult<FoodDO>> GetIngredientFood(string id)
        {
            var iControll = new IngredientController();
            
            var objetos = await daoFI.RetornarTodosAsync();

            var ingredientes = new List<Ingredient>();

            foreach (var obj in objetos)
            {
                if (id == obj.IdFood)
                {
                    Console.WriteLine(obj.IdIngredient);
                    var ing = await daoI.RetornarPorIdAsync(obj.IdIngredient);
                    ingredientes.Add(ing);
                }
            }

            return Ok(ingredientes);
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
        private FoodIngredientDAO daoFI = new FoodIngredientDAO();
        private IngredientDAO daoI = new IngredientDAO();
    }
}