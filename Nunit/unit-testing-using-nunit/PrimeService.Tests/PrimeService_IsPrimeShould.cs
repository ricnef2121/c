using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {   
        private readonly PrimeService _primerService;
        public PrimeService_IsPrimeShould(){
            _primerService = new PrimeService();
        }
        [Test]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            
            var result =_primerService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        }
        
        #region Sample_TestCode
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void IsPrime_ValuesLessthan2_ReturnFalse(int value){
            var result = _primerService.IsPrime(value);
            Assert.IsFalse(result,$"{value} no debe ser prime");
        }
        
        #endregion
    }
}