using System;


namespace LeetSpeak
{
  public class LeetSpeak
  {
    public static string word;

    public LeetSpeak(string inputWord)
    {
      word = inputWord;
    }

    public static string Convert()
    {
      char eChar = System.Convert.ToChar("e");
      char threeChar = System.Convert.ToChar("3");
      char[] wordArray = word.ToCharArray();
      for (var i = 0; i < wordArray.Length; i++)
      {
        if (wordArray[i] == eChar)
        {
          wordArray[i] = threeChar;
        }
      }
      string output = string.Join("", wordArray);
      return output;
    }
  }
}
