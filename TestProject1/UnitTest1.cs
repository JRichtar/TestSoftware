using NUnit.Framework;
using TestSoftware;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatesNewQuiz_ReturnsTrue()
        {
            // Arrange

            var test = new Test();

            //Act

            Test result = test;

            // Assert

            Assert.IsTrue(result);

            /* 
                Chtěl bych se omluvit, že tuto část nemám. Zkrátka tomu stále nerozumím, snažil jsem se najít
                nějakou nápovědu na internetu, ale testování programů není moje silná stránka. 

            */
        }
    }
}