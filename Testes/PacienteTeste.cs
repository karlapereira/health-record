using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio;
using TO;

namespace Testes
{
  [TestClass]
  public class PacienteTeste
  {
    [TestMethod]
    public void NovoPaciente()
    {
      try
      {
        PacienteNegocio negPaciente = new PacienteNegocio();

        PacienteTO paciente = new PacienteTO();
        paciente.Nome = "João da Silva";
        paciente.NomeMae = "Maria Silva";
        paciente.Nascimento = DateTime.Today.AddYears(-10);
        paciente.Sexo = SexoEnum.Masculino;

        negPaciente.Adicionar(paciente);
      }catch(Exception ex)
      {
        Assert.Fail(ex.Message);
      }
      
      
    }
  }
}
