using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastroFoodDll.DOs
{
    public class FoodIngredientDO : BaseDO
    {
        public string IdFood { get; set; } = "";

        public string IdIngredient { get; set; }= "";
    }
}