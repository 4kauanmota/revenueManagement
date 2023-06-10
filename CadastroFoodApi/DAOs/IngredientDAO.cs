using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFoodApi.Models;

namespace CadastroFoodApi.DAOs
{
    public class IngredientDAO : AutoDAO<Ingredient>
    {
        protected override string Tabela => "ingredient";
    }
}

