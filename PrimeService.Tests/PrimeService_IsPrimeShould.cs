using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(17, true)]
        [InlineData(18, false)]
        [InlineData(19, true)]
        public void ReturnCorrectPrimality(int value, bool expected)
        {
            var result = _primeService.IsPrime(value);

            Assert.Equal(expected, result);
        }
    }
}