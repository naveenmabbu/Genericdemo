
namespace GenericDemo
{
	 class program
	{
		static int[] intArray = { 2, 4, 5, 6, 8 };
		static char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
		static double[] doubleArray = { 1.1, 3.3, 5.5, 8.7 };
		static void Main(String[] args)
		{
			Display<int>(intArray);
			Display<char>(charArray);
			Display<Double>(doubleArray);
			Console.ReadKey();

			static void Display<T>(T[] test)
			{
				for (int i = 0; i < test.Length; i++)
				{
					Console.Write(test[i] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}