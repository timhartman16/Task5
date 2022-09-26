using System;
using System.IO;

class Program
{
	static void Main(string[] args)
	{
		TransformToElephant();
		Console.WriteLine("Муха");
        //... custom application code
	}

	static void TransformToElephant()
	{
		unsafe
        {
			string muha = "Муха";
			fixed (char* ptr = muha)
            {
				ptr[0] = 'C';
				ptr[1] = 'л';
				ptr[2] = 'о';
				ptr[3] = 'н';
			}
		}
	}
}
