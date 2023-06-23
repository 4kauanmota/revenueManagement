using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CadastroFoodDll.DOs;

namespace CadastroIngredientDll.DOs
{
    public class IngredientDO : BaseDO
    {

        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Name { get; set; } = "";
        
        [Range(0, 50, ErrorMessage = "O peso deve estar entre 0 50kg.")]
        public double Weight { get; set; }
    }
}