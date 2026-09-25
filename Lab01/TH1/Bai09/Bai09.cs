public class Program9
{
	public static void TimMaxMin(
		float first,
		float second,
		float third,
		out float maximum,
		out float minimum)
	{
		maximum = Math.Max(first, Math.Max(second, third));
		minimum = Math.Min(first, Math.Min(second, third));
	}
}
