using GenericProblems;
namespace FindMaxNumTest
{
    public class Tests
    {
        GenericClass<int> genericMethodForInt=new GenericClass<int>();
        GenericClass<double> genericMethodForDouble = new GenericClass<double>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = genericMethodForInt.FindMaximumGeneric(26, 20, 17);
            Assert.AreEqual(26, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = genericMethodForInt.FindMaximumGeneric(26, 30, 17);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = genericMethodForInt.FindMaximumGeneric(26, 30, 37);
            Assert.AreEqual(30, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMaxdouble()
        {
            double result = genericMethodForDouble.FindMaximumGeneric(2.6, 2.3, 2.2);
            Assert.AreEqual(2.6, result);
        }
    }
}