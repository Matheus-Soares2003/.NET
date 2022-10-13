using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;

namespace ExemploExplorando.Models
{
    public class Curso
    {

        public string nome { get; set; }
        public List<Pessoa> alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
           alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            alunos.Remove(aluno);
        }

        public void ListarAluno()
        {
            Console.WriteLine($"Alunos do curso de {nome}");
            foreach (var pessoa in alunos)
            {
                Console.WriteLine(pessoa.NomeCompleto);
            }
        }

        public int ObterQuantidadeAlunos()
        {
            int qtd = alunos.Count;
            return qtd;
        }
    }
}