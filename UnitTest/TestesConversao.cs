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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.FtToM(valor);

                Assert.IsNotNull(resultado);
                Assert.AreEqual(resultadoEsperado, resultado);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void MToFt_Test_Conversao()
        {
            try
            {
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.MToFt(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.SqydToM2(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.M2ToSqyd(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.CuftToM3(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.M3ToCuft(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.LbToKg(valor);

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
                double valor = 0.00;
                double resultadoEsperado = 0.00;
                double resultado = OperacoesMatematicas.KgToLb(valor);

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
