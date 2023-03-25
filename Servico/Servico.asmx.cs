﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TO;

namespace Servico
{
  /// <summary>
  /// Descrição resumida de Servico
  /// </summary>
  [WebService(Namespace = "http://tempuri.org/")]
  [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
  [System.ComponentModel.ToolboxItem(false)]
  // Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
  // [System.Web.Script.Services.ScriptService]
  public class Servico : System.Web.Services.WebService
  {

    [WebMethod]
    public List<PacienteTO> GetMeusPacientes()
    {
      PacienteNegocio negPaciente = new PacienteNegocio();
      return negPaciente.GetMeusPacientes();
    }
  }
}
