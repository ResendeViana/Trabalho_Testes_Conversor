using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Testes_Conversor.BusinessLayer
{
    public class OperacoesMatematicas
    {
        public static double FtToM(double valor)
        {
            return valor * Constantes.ft_m;
        }

        public static double MToFt(double valor)
        {
            return valor * Constantes.m_ft;
        }

        public static double SqydToM2(double valor)
        {
            return valor * Constantes.sqyd_m2;
        }

        public static double  M2ToSqyd(double valor)
        {
            return valor * Constantes.m2_sqyd;
        }

        public static double CuftToM3(double valor)
        {
            return valor * Constantes.cuft_m3;
        }

        public static double M3ToCuft(double valor)
        {
            return valor * Constantes.m3_cuft;
        }

        public static double LbToKg(double valor)
        {
            return valor * Constantes.lb_kg;
        }

        public static double KgToLb(double valor)
        {
            return valor * Constantes.kg_lb;
        }

        public static double MphToKph(double valor)
        {
            return valor * Constantes.mph_kph;
        }

        public static double KphToMph(double valor)
        {
            return valor * Constantes.kph_mph;
        }
    }
}
