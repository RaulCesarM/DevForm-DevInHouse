using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForm {
    public class CobrarCurso {

        private double ValorCurso { get; set; }
        private double ValorMulta { get; set; }
        private double ValorDesconto { get; set; }
        public double Resultado { get; set; }


        public CobrarCurso() {
        }
        public CobrarCurso( double vCurso, double VMulta, double Vdesconto) {
            this.ValorCurso = vCurso;
            this.ValorMulta = VMulta;
            this.ValorDesconto = Vdesconto;
        }

        public double MostrarResultado() {
          return this.Resultado = CalcularMulta();
        }

        private double CalcularMulta() {

            double resultado;

            if (this.ValorMulta > 0) {
               resultado = this.ValorCurso + this.ValorMulta;
            } else {
                resultado = this.ValorCurso - this.ValorDesconto;
            }            

            return resultado;
        }
       

    }
}
