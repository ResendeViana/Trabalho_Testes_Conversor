using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trabalho_Testes_Conversor.BusinessLayer;

namespace UnitTest
{
    [TestClass]
    public class TestesConversao
    {
        [TestMethod]
        public void FtToM_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 3.048;
                double resultado = OperacoesMatematicas.FtToM(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void MToFt_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 32.808;
                double resultado = OperacoesMatematicas.MToFt(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void SqydToM2_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 8.361;
                double resultado = OperacoesMatematicas.SqydToM2(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void M2ToSqyd_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 11.960;
                double resultado = OperacoesMatematicas.M2ToSqyd(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void CuftToM3_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 0.283;
                double resultado = OperacoesMatematicas.CuftToM3(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void M3ToCuft_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 353.147;
                double resultado = OperacoesMatematicas.M3ToCuft(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void LbToKg_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 4.536;
                double resultado = OperacoesMatematicas.LbToKg(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void KgToLb_Test_Conversao()
        {
            try
            {
                double valor = 10.00;
                double resultadoEsperado = 22.046;
                double resultado = OperacoesMatematicas.KgToLb(valor);
                resultado = Math.Round(resultado, 3);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);

            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
