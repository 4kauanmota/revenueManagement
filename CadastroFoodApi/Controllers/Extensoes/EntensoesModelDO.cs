using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroFoodDll.DOs;
using CadastroFoodApi.DAOs;
using CadastroFoodApi.Models;

namespace CadastroFoodApi.Controllers.Extensoes
{
    public static class EntensoesModelDO
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
    }
}