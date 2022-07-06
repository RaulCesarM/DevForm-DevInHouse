using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevForm {

    
    public static class FormatacaoTexto {

      

            public static string formataco(string Nome, double ValorCurso) {
            string nome = Nome;
            double valor = ValorCurso;            
            return $"Nome {nome}, Valor {valor}";

        }
        public static string formataco(string Nome, double ValorCurso, double Desconto) {
            string nome = Nome;
            double valor = ValorCurso;
            double desconto = Desconto;
            valor -= desconto;
            return $"Nome {nome}, Valor {valor}, Valor do desconto{desconto}";

        }

        public static string formataco(string Nome, double ValorCurso, double Desconto, int Idade) {
            string nome = Nome;
            double valor = ValorCurso;
            double desconto = Desconto;
            valor -= desconto;
            int idade = Idade;
            return $"Nome {nome}, Valor {valor}, Valor do desconto{desconto}, idade {idade}";

        }











    }   
}
