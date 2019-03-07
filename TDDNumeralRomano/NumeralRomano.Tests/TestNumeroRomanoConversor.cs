using System;
using Xunit;

namespace NumeralRomano.Tests
{
    public class TestNumeroRomanoConversor
    {
        private NumeralRomanoConversor _numeroRomanoConversor;

        public TestNumeroRomanoConversor()
        {
            _numeroRomanoConversor = new NumeralRomanoConversor();
        }


        [Theory]
        [InlineData(1, "I")]
        public void ValidaValor(int numero, string resultado)
        {
            Assert.True(_numeroRomanoConversor.InteiroParaRomano(numero) == resultado);
        }
    }
}
