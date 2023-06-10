namespace CadastroFoodApi.Models
{
    public class Ingredient : BaseModel
    {
        public string Name { get; set; } = "";

        public double Weight { get; set; }

    }
}