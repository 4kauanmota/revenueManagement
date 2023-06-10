using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFoodApi.Models;

namespace CadastroFoodApi.DAOs
{
    public class FoodIngredientDAO : AutoDAO<FoodIngredient>
    {
        protected override string Tabela => "food_ingredient";
        
    }
}
