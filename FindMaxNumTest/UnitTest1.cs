using GenericProblems;
namespace FindMaxNumTest
{
    public class Tests
    {
        GenericClass<int> genericMethodForInt=new GenericClass<int>();
        GenericClass<float> genericMethodForfloat = new GenericClass<float>();
        GenericClass<string> genericMethodForstring = new GenericClass<string>();
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
            float result = genericMethodForfloat.FindMaximumGeneric(2.6f, 2.3f, 2.2f);
            Assert.AreEqual(2.6f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMaxdouble()
        {
            float result = genericMethodForfloat.FindMaximumGeneric(2.6f, 3.2f, 2.2f);
            Assert.AreEqual(3.2f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMaxdouble()
        {
            float result = genericMethodForfloat.FindMaximumGeneric(2.4f,4.6f,12.1f);
            Assert.AreEqual(12.1f, result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMaxstring()
        {
            string result = genericMethodForstring.FindMaximumGeneric("Apple","Ball","Cat");
            Assert.AreEqual("Apple", result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnSecondMaxstring()
        {
            string result = genericMethodForstring.FindMaximumGeneric("Apple", "Clothes", "Cat");
            Assert.AreEqual("Clothes", result);
        }
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnThirdMaxstring()
        {
            string result = genericMethodForstring.FindMaximumGeneric("Apple", "Clothes", "Catloague");
            Assert.AreEqual("Catloague", result);
        }
    }
}