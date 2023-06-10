using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFoodApi.Models
{
    public class Food : BaseModel
    {
        public string Name { get; set; } = "";

        public double Weight { get; set; }

        public double Time { get; set; }
    }
}