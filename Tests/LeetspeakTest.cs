using Xunit;
namespace Leetspeak
{
  public class TestLeetspeak
  {
    [Fact]
    public void IsLeetspeak_ForStoZ_true()
    {
      string phrase ="3p1c0duz";
      Leetspeak testLeetspeak = new Leetspeak();
      Assert.Equal(phrase, testLeetspeak.IsLeetspeak("Epicodus"));
    }
  }
}
