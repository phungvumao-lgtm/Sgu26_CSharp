public class Program11
{
	public static string DaoChuoi(string input)
	{
		char[] characters = input.ToCharArray();
		Array.Reverse(characters);
		return new string(characters);
	}
}