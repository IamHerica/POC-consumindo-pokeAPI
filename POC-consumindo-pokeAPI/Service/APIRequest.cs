using Newtonsoft.Json;
using POC_consumindo_pokeAPI.Models;
using System;
using System.IO;
using System.Net;

namespace POC_consumindo_pokeAPI.Service
{
    public class APIRequest
    {
        public ScopeResponse GetList()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://pokeapi.co/api/v2/pokemon?limit=100000&offset=0");
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        if (stream == null) return null;

                        using(StreamReader reader = new StreamReader(stream))
                        {
                            var responseText = reader.ReadToEnd();

                            var pokeList = JsonConvert.DeserializeObject<ScopeResponse>(responseText);
                            return pokeList;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
