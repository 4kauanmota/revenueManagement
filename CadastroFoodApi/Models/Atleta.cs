using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFoodApi.Models
{
    public class Food : BaseModel
    {
        public string Nome { get; set; } = "";

        public double Altura { get; set; }

        public double Peso { get; set; }
    }
}