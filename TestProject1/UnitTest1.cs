namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string firstName = "nathaniel";
            string lastName = "haWthorNe";
            string expected = "#_Hawthorne, Nathaniel(HAWNAT)";
            string actual = ConsoleApp3.Codetest.Formatter(firstName, lastName);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        { 
            String first1 = "ELisabeth";
            string last1 = "GEorge";
            string expected1 = "#_George, Elisabeth(GEOELI)";
            string actual1 = ConsoleApp3.Codetest.Formatter(first1, last1);
            Assert.Equal(expected1, actual1);
        }
    }
}