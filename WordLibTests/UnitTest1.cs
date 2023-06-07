using WordLib;

namespace WordLibTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsPalindrome()
    {

        Worder worder = new Worder();

        // create an instant
        string Palindrome = "radar";
        // run the method under test
        bool resultat = worder.Ispalindrome();

        //verify the result
        Assert.IsTrue(resultat);


    }
}

