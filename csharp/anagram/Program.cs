// See https://aka.ms/new-console-template for more information
namespace Anagram
{
  class Program
  {
    static bool AreAnagrams(string str1, string str2)
    {
      str1 = str1.Replace(" ", "").ToLower();
      str2 = str2.Replace(" ", "").ToLower();

      if (str1.Length != str2.Length) return false;

      char[] arr1 = str1.ToCharArray();
      char[] arr2 = str2.ToCharArray();

      Array.Sort(arr1);
      Array.Sort(arr2);

      return new string(arr1) == new string(arr2);
    }

    static void Main(string[] args)
    {
      Console.WriteLine("This a Anagrams listen and silent? ");
      Console.WriteLine(AreAnagrams("listen", "silent"));
    }
  }
}