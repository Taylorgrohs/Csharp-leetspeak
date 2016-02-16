using Xunit;
namespace LeetSpeak
{
  public class LeetSpeakTest
  {
    [Fact]
    public void IsLeetSpeak_Einto3()
    {
      string testCompare = "t3st3r";
      string testInput = "tester";
      var testLeetSpeak = new LeetSpeak(testInput);
      string output = LeetSpeak.Convert();

      Assert.Equal(testCompare, output);
    }
  }
}
