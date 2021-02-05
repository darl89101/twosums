using NSubstitute;
using NUnit.Framework;
using TwoSums;

namespace NUnitTestProject1
{
    public class TwoSumTests
    {
        private ITwoSumService _twoSum;
        private IFixedArray _fixedArray;

        [SetUp]
        public void Setup()
        {
            _twoSum = new TwoSumService();
            _fixedArray = Substitute.For<IFixedArray>();
        }

        [Test]
        public void Find_Indices_By_Array_ShouldReturn_NotNull()
        {
            var array = new[] { 9, 4, 6, 3, 8, 5, 4 };
            var objective = 9;
            var expectedResponse = new IndicesModel { Indice1 = 1, Indice2 = 5 };
            _fixedArray.GetArray().Returns(array);

            var response = _twoSum.FindIndicesByArrayAndObjetive(_fixedArray, objective);

            Assert.AreEqual(expectedResponse.Indice1, response.Indice1);
            Assert.AreEqual(expectedResponse.Indice2, response.Indice2);
        }

        [Test]
        public void Find_Indices_By_Array_ShouldReturn_Null()
        {
            var array = new[] { 1, 4, 6, 3, 8, 5, 4 };
            var objective = 2;
            _fixedArray.GetArray().Returns(array);

            Assert.IsNull(_twoSum.FindIndicesByArrayAndObjetive(_fixedArray, objective));
        }
    }
}