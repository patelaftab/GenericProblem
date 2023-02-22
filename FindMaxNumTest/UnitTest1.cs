using GenericProblems;
namespace FindMaxNumTest
{
    public class Tests
    {
        GenericClass<int> genericMethodForInt=new GenericClass<int>();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            int result = genericMethodForInt.FindMaximumGeneric(26, 20, 17);
            Assert.AreEqual(26, result);
        }
    }
}