using System;

class ReverseNo
{
	public static void Main(String[] args)
	{
		int inputNo, reverseNo=0;
		Console.WriteLine("Enter the number: ");
		inputNo = Convert.ToInt32(Console.ReadLine());
		
		while(inputNo>0){
			int lastDigit = inputNo % 10;
			reverseNo = reverseNo * 10 + lastDigit;
			inputNo = inputNo/10;
		}

		Console.WriteLine("The Reverse no is: " + reverseNo);
		Console.ReadLine();
	}

}