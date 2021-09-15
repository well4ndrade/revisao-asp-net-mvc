using AulasRevisaoDesafio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulasRevisaoAspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Blabla = "Bla blaage.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Alunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            var aluno = new Aluno()
            {
                Id = 1,
                Nome = "Wesley",
                Matricula = "001"
            };

            aluno.Notas.Add(9);
            aluno.Notas.Add(10);

            alunos.Add(aluno);

            ViewBag.Alunos = alunos;

            return View();
        }
    }
}