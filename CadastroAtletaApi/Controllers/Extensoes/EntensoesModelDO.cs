using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroAtletaApi.DAOs;
using CadastroAtletaApi.Models;
using CadastroAtletaDll.DOs;

namespace CadastroAtletaApi.Controllers.Extensoes
{
    public static class EntensoesModelDO
    {
        public static AtletaDO ToDO(this Atleta obj)
        {
            return new AtletaDO
            {
                Id = obj.Id,
                Nome = obj.Nome,
                Altura = obj.Altura,
                Peso = obj.Peso
            };
        }

        public static IList<AtletaDO> ToDO(this IList<Atleta> listaModels)
        {
            var lista = new List<AtletaDO>();

            foreach (var obj in listaModels)
                lista.Add(ToDO(obj));

            return lista;
        }
        
        public static async Task<Atleta> ToModel(this AtletaDO objDO)
        {
            Atleta? obj = null;

            if (objDO.Id != null)
            {
                var dao = new AtletaDAO();
                obj = await dao.RetornarPorIdAsync(objDO.Id);
            }

            if (obj == null)
                obj = new Atleta();

            obj.Nome = objDO.Nome;
            obj.Altura = objDO.Altura;
            obj.Peso = objDO.Peso;

            return obj;
        }

        public static async Task<IList<Atleta>> ToModel(this IList<AtletaDO> listaDO)
        {
            var lista = new List<Atleta>();

            foreach (var obj in listaDO)
                lista.Add(await ToModel(obj));

            return lista;
        }
    }
}