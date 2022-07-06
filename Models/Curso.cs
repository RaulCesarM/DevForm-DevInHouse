using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForm.Models {
    public class Curso {

        public int IdCurso { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }

        public Curso() {
        }
        public Curso(string nome, double valor, double desconto) {
            this.Nome = nome;
            this.Valor = valor;
            this.Desconto = desconto;
        }



    }
}
