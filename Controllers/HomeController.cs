using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using vElevadores.Repository;

namespace vElevadores.Controllers
{
    public class HomeController : Controller
    {   
        public ActionResult Index()
        {
            return View();          
        }


        public JsonResult AndarMenosUtilizado()
        { 
            List<int> lista = new ElevadorService().andarMenosUtilizado();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }


        public JsonResult ElevadorMaisFrequentado()
        {
            List<char> lista = new ElevadorService().elevadorMaisFrequentado();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }



        public JsonResult PeriodoMaiorFluxoElevadorMaisFrequentado()
        {
            List<char> lista = new ElevadorService().periodoMaiorFluxoElevadorMaisFrequentado();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }


        public JsonResult ElevadorMenosFrequentado()
        {
            List<char> lista = new ElevadorService().elevadorMenosFrequentado();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }

        public JsonResult PeriodoMenorFluxoElevadorMenosFrequentado()
        {
            List<char> lista = new ElevadorService().periodoMenorFluxoElevadorMenosFrequentado();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }

        public JsonResult PeriodoMaiorUtilizacaoConjuntoElevadores()
        {
            List<char> lista = new ElevadorService().periodoMaiorUtilizacaoConjuntoElevadores();

            return Json(new { retorno = "OK", valor = String.Join(",", lista.ToList()) });
        }



        public JsonResult PercentualDeUsoElevadorA()
        {
            float retorno = new ElevadorService().percentualDeUsoElevadorA();

            return Json(new { retorno = "OK", valor = retorno.ToString() + "%" });
        }

        public JsonResult PercentualDeUsoElevadorB()
        {
            float retorno = new ElevadorService().percentualDeUsoElevadorB();

            return Json(new { retorno = "OK", valor = retorno.ToString() + "%" });
        }

        public JsonResult PercentualDeUsoElevadorC()
        {
            float retorno = new ElevadorService().percentualDeUsoElevadorC();

            return Json(new { retorno = "OK", valor = retorno.ToString() + "%" });
        }

        public JsonResult PercentualDeUsoElevadorD()
        {
            float retorno = new ElevadorService().percentualDeUsoElevadorD();

            return Json(new { retorno = "OK", valor = retorno.ToString() + "%" });
        }

        public JsonResult PercentualDeUsoElevadorE()
        {
            float retorno = new ElevadorService().percentualDeUsoElevadorE();

            return Json(new { retorno = "OK", valor = retorno.ToString()+"%" });
        }


    }
}