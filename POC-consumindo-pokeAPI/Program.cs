using POC_consumindo_pokeAPI.Models;
using POC_consumindo_pokeAPI.Service;
using System;

namespace POC_consumindo_pokeAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoadData();
        }

        private static void LoadData()
        {
            var api = new APIRequest();
            var pokeList = new ScopeResponse();
            pokeList = api.GetList();

            foreach (var item in pokeList.Results)
            {
                Console.WriteLine($"Pokemon: {item.Name}");
            }

            Console.WriteLine($"Amount of pokemon: {pokeList.Results.Count}");
        }
    }
}
