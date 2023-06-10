using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFoodApi.Models;

namespace CadastroFoodApi.DAOs
{
    public class FoodDAO : AutoDAO<Food>
    {
        protected override string Tabela => "food";
    }
}