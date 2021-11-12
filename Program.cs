using System;
using System.Collections;

public class Program {

	static bool isPalindrome(int num) {
		int tempValue = num;
		int reverse = 0;
		while (tempValue > 0) {
			reverse = reverse * 10 + tempValue % 10;
			tempValue = tempValue / 10;
		}

		return reverse == num;
	}

	public static void Main(string[] args) {
		int num;
		Console.WriteLine("Skriv in ett nummer :");
		num = int.Parse(Console.ReadLine());

		if (isPalindrome(num)) {
			Console.WriteLine("Ditt nummer är ett palindrom");
		} else {
			Console.WriteLine("Ditt nummer är inte ett palindrom");
		}
	}
}
