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
        public string Name { get; set; } = "";
        
        [Range(0, 50,
        ErrorMessage = "O peso deve estar entre 0 50kg.")]
        public double Weight { get; set; }

        [Range(0, 1000,
        ErrorMessage = "O tempo deve estar entre 0 e 1000m.")]
        public double Time { get; set; }
        
        [StringLength(255, ErrorMessage = "A descricao deve ter no máximo 255 caracteres.")]
        public string Description { get; set; } = "";
        
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Preparation { get; set; } = "";
    }
}