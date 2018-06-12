using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Testes_Conversor.BusinessLayer;

namespace Trabalho_Testes_Conversor.View
{
    public class VelocidadeMock
    {
        public double VelocidadeMockImperial(string input)
        {
            double variavel = double.Parse(input);
            
            double resultado = OperacoesMatematicas.MphToKph(variavel);
            return resultado;

        }
        public double VelocidadeMockMetrico(string input)
        {
            double variavel = double.Parse(input);
            
            double resultado = OperacoesMatematicas.KphToMph(variavel);
            return resultado;
        }

    }
}
