using Dados;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace Repositorio
{
  public class PacienteRepositorio : RepositorioBase
  {
    public PacienteTO GetPacientePorId (int id)
    {
      Paciente paciente = this.Contexto.Pacientes.Where(p => p.Id == id).FirstOrDefault();
      return paciente.ToPacienteTO();
    }

    public List<PacienteTO> GetTodos()
    {
      List<Paciente> pacientes = this.Contexto.Pacientes.ToList();
      return pacientes.Select(s => s.ToPacienteTO()).ToList();
    }

    public void Novo(PacienteTO paciente)
    {
      Paciente entity = new Paciente();
      entity.DataCriacao = DateTime.Now;
      entity.DataEdicao = DateTime.Now;
      entity.Apply(paciente);
      this.Contexto.Pacientes.Add(entity);
      this.Contexto.SaveChanges();
    }

    public void Atualiza(PacienteTO paciente)
    {
      Paciente entity = this.Contexto.Pacientes.Where(p => p.Id == paciente.Id).FirstOrDefault();
      entity.Apply(paciente);
      entity.DataEdicao = DateTime.Now;
      this.Contexto.Entry(entity).State = EntityState.Modified;
      this.Contexto.SaveChanges();
    }
  }
}
