using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForm.Models {
    public class Aluno {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string CursoInscrito  { get; set; }
        public int Idade { get; set; }
        public string Nascimento { get; set; }

        public Aluno() {
        }
        public Aluno(string nome, string sobrenome,string cursoinscrito, int idade, string nascimento) {
            this.Nome = nome;
            this.SobreNome = sobrenome;
            this.CursoInscrito = cursoinscrito;
            this.Idade = idade;
            this.Nascimento = nascimento;
        }

    }
}
