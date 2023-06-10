using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFoodDll.DOs;
using CadastroFoodApi.DAOs;
using CadastroFoodApi.Models;

namespace CadastroFoodApi.Controllers.Extensoes
{
    public static class ExtensionsModelDO
    {
        public static FoodDO ToDO(this Food obj)
        {
            return new FoodDO
            {
                Id = obj.Id,
                Name = obj.Name,
                Weight = obj.Weight,
                Time = obj.Time
            };
        }

        public static IList<FoodDO> ToDO(this IList<Food> listaModels)
        {
            var lista = new List<FoodDO>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }
        
        public static async Task<Food> ToModel(this FoodDO objDO)
        {
            Food? obj = null;

            if (objDO.Id != null)
            {
                var dao = new FoodDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new Food();

            obj.Name = objDO.Name;
            obj.Weight = objDO.Weight;
            obj.Time = objDO.Time;

            return obj;
        }

        public static async Task<IList<Food>> ToModel(this IList<FoodDO> listaDO)
        {
            var lista = new List<Food>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }
        
        public static Ingredient ToDO(this Ingredient obj)
        {
            return new Ingredient
            {
                Id = obj.Id,
                Name = obj.Name,
                Weight = obj.Weight,
            };
        }
        
        public static IList<Ingredient> ToDO(this IList<Ingredient> listaModels)
        {
            var lista = new List<Ingredient>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }
        
        public static async Task<Ingredient> ToModel(this Ingredient objDO)
        {
            Ingredient? obj = null;

            if (objDO.Id != null)
            {
                var dao = new IngredientDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new Ingredient();

            obj.Name = objDO.Name;
            obj.Weight = objDO.Weight;

            return obj;
        }
        
        public static async Task<IList<Ingredient>> ToModel(this IList<Ingredient> listaDO)
        {
            var lista = new List<Ingredient>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }
        
        public static FoodIngredient ToDO(this FoodIngredient obj)
        {
            return new FoodIngredient
            {
                Id = obj.Id,
                IdFood = obj.IdFood,
                IdIngredient = obj.IdIngredient,
            };
        }
        
        public static IList<FoodIngredient> ToDO(this IList<FoodIngredient> listaModels)
        {
            var lista = new List<FoodIngredient>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }
        
        public static async Task<FoodIngredient> ToModel(this FoodIngredient objDO)
        {
            FoodIngredient? obj = null;

            if (objDO.Id != null)
            {
                var dao = new FoodIngredientDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new FoodIngredient();

            obj.IdFood = objDO.IdFood;
            obj.IdIngredient = objDO.IdIngredient;
            return obj;
        }
        
        public static async Task<IList<FoodIngredient>> ToModel(this IList<FoodIngredient> listaDO)
        {
            var lista = new List<FoodIngredient>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }
    }
}