using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using vElevadores.Models;
using WsElevadores.Interface;

namespace vElevadores.Repository
{

    public class ElevadorService : IElevadorService
    {

        HttpClient cliente = null;

        public ElevadorService()
        {
            cliente = new HttpClient();

            string link = ConfigurationManager.AppSettings["ApiUrl"];
            cliente.BaseAddress = new Uri(link);
            cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }


        public List<int> andarMenosUtilizado()
        {
            var reposta = cliente.GetAsync($@"api/andarMenosUtilizado").Result;

            List<int> ListaElevadores = new List<int>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<int>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;
        }

        public List<char> elevadorMaisFrequentado() 
        {
            var reposta = cliente.GetAsync($@"api/elevadorMaisFrequentado").Result;

            List<char> ListaElevadores = new List<char>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<char>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;
        }

        /// <summary> Deve retornar uma List contendo o período de maior fluxo de cada um dos elevadores mais frequentados (se houver mais de um). </summary> 
        public List<char> periodoMaiorFluxoElevadorMaisFrequentado()
        {
            var reposta = cliente.GetAsync($@"api/periodoMaiorFluxoElevadorMaisFrequentado").Result;

            List<char> ListaElevadores = new List<char>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<char>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;

        }
        /// <summary> Deve retornar uma List contendo o(s) elevador(es) menos frequentado(s). </summary> 
        public List<char> elevadorMenosFrequentado()
        {
            var reposta = cliente.GetAsync($@"api/elevadorMenosFrequentado").Result;

            List<char> ListaElevadores = new List<char>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<char>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;

        }

        /// <summary> Deve retornar uma List contendo o período de menor fluxo de cada um dos elevadores menos frequentados (se houver mais de um). </summary> 
        public  List<char> periodoMenorFluxoElevadorMenosFrequentado()
        {
            var reposta = cliente.GetAsync($@"api/periodoMenorFluxoElevadorMenosFrequentado").Result;

            List<char> ListaElevadores = new List<char>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<char>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;

        }

        /// <summary> Deve retornar uma List contendo o(s) periodo(s) de maior utilização do conjunto de elevadores. </summary> 
        public  List<char> periodoMaiorUtilizacaoConjuntoElevadores()
        {
            var reposta = cliente.GetAsync($@"api/periodoMaiorUtilizacaoConjuntoElevadores").Result;

            List<char> ListaElevadores = new List<char>();

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                ListaElevadores = JsonConvert.DeserializeObject<List<char>>(reposta.Content.ReadAsStringAsync().Result);
            }

            return ListaElevadores;

        }

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador A em relação a todos os serviços prestados. </summary> 
        public float percentualDeUsoElevadorA()
        {
            var reposta = cliente.GetAsync($@"api/percentualDeUsoElevadorA").Result;

            float retorno =0 ;

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                retorno = JsonConvert.DeserializeObject<float>(reposta.Content.ReadAsStringAsync().Result);
            }

            return (float)Math.Round(retorno, 2); 
        }

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador B em relação a todos os serviços prestados. </summary> 
        public float percentualDeUsoElevadorB()
        {
            var reposta = cliente.GetAsync($@"api/percentualDeUsoElevadorB").Result;

            float retorno = 0;

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                retorno = JsonConvert.DeserializeObject<float>(reposta.Content.ReadAsStringAsync().Result);
            }

            return (float)Math.Round(retorno, 2);
        }

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador C em relação a todos os serviços prestados. </summary> 
        public float percentualDeUsoElevadorC()
        {
            var reposta = cliente.GetAsync($@"api/percentualDeUsoElevadorC").Result;

            float retorno = 0;

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                retorno = JsonConvert.DeserializeObject<float>(reposta.Content.ReadAsStringAsync().Result);
            }

            return (float)Math.Round(retorno, 2);
        }

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador D em relação a todos os serviços prestados. </summary> 
        public float percentualDeUsoElevadorD()
        {
            var reposta = cliente.GetAsync($@"api/percentualDeUsoElevadorD").Result;

            float retorno = 0;

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                retorno = JsonConvert.DeserializeObject<float>(reposta.Content.ReadAsStringAsync().Result);
            }

            return (float)Math.Round(retorno, 2);
        }

        /// <summary> Deve retornar um float (duas casas decimais) contendo o percentual de uso do elevador E em relação a todos os serviços prestados. </summary> 
        public float percentualDeUsoElevadorE()
        {
            var reposta = cliente.GetAsync($@"api/percentualDeUsoElevadorE").Result;

            float retorno = 0;

            if (reposta.StatusCode == HttpStatusCode.OK)
            {
                retorno = JsonConvert.DeserializeObject<float>(reposta.Content.ReadAsStringAsync().Result);
            }

            return (float)Math.Round(retorno, 2);
        }


    }
}