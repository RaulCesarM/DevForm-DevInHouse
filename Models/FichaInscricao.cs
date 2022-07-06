using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForm {
    public class FichaInscricao {

        private string Nome {get; set;}
        private int Idade  {get; set;}
        private string Escolaridade {get; set;}
        private DateTime Nascimento {get; set;}
        private double ValorCurso {get; set;}
        private double ValorDesconto {get; set;}
        private double ValorMulta {get; set;}

        public FichaInscricao() {

        }
        public FichaInscricao(string Nome, 
                                int Idade,
                                string Escolaridade,
                                DateTime Nascimento,
                                double ValorCurso,
                                double ValorDesconto,
                                double ValorMulta) {

            this.Nome = Nome;           
            this.Escolaridade = Escolaridade;
            this.ValorCurso = ValorCurso;
            this.ValorDesconto = ValorDesconto;
            this.ValorMulta = ValorMulta;

            int idade = DateTime.Now.Year - Nascimento.Year;
            if (DateTime.Now.DayOfYear < Nascimento.DayOfYear) {
                this.Idade = idade - 1;
            }
            this.Idade = idade;
        }

    












    }
}
