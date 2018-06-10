using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Testes_Conversor.BusinessLayer
{
    public class OperacoesPadrao
    {
        public static double ConvertDoubleCustom(string valor)
        {
            try
            {
                double auxiliar = 0;

                if (!string.IsNullOrEmpty(valor))
                {
                    string stringAuxiliar = valor.Trim().Replace(',', '.');
                    auxiliar = Convert.ToDouble(stringAuxiliar);
                }

                return auxiliar;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
