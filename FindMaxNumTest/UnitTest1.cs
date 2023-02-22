using GenericProblems;
namespace FindMaxNumTest
{
    public class Tests
    {
        GenericClass<int> genericMethodForInt=new GenericClass<int>();
        GenericClass<float> genericMethodForDouble = new GenericClass<float>();
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
            float result = genericMethodForDouble.FindMaximumGeneric(2.6f, 2.3f, 2.2f);
            Assert.AreEqual(2.6f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMaxdouble()
        {
            float result = genericMethodForDouble.FindMaximumGeneric(2.6f, 3.2f, 2.2f);
            Assert.AreEqual(3.2f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMaxdouble()
        {
            float result = genericMethodForDouble.FindMaximumGeneric(2.4f,4.6f,12.1f);
            Assert.AreEqual(12.1f, result);
        }
    }
}