public class Program8
{
	public static void HoanVi(ref float first, ref float second)
	{
		float temporary = first;
		first = second;
		second = temporary;
	}
}