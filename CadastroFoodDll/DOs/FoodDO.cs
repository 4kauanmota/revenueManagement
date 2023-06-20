using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CadastroFoodDll.DOs
{
    public class FoodDO : BaseDO
    {

        [Required]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]        
        public string Name { get; set; }
        
        [Range(0, 3,
        ErrorMessage = "A altura deve estar entre 0,9 e 3 metros.")]
        public double Weight { get; set; }

        [Range(10, 500,
        ErrorMessage = "O peso deve estar entre 20 e 500Kg.")]
        public double Time { get; set; }
        
        [StringLength(255, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Description { get; set; } = "";
        
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Preparation { get; set; } = "";
    }
}