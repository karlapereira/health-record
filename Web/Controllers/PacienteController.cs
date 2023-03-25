using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMaterializacao.Controllers
{
  public class PacienteController : Controller
  {
    // GET: Paciente
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult ListaPacientes()
    {
      ServicoExposto.ServicoSoapClient servico = new ServicoExposto.ServicoSoapClient();
      
      return View(servico.GetMeusPacientes());
    }

  }
}