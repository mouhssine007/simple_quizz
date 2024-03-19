using System;

namespace simple_quizz
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] questions = new string[3]
			{
				"1. what is the capital of Morocco",
				"2. what is the red planet?",
				"3. what is the largest animal"
			};
			string[] answers = new string[3] { "Rabat", "Mars", "Whales" };
			Console.WriteLine("Welcome user.");
			Console.WriteLine("Please answer the following questions:");
			for (int i = 0; i < questions.Length; i++) // Fixed the loop condition
			{
				Console.WriteLine(questions[i]);
			
				string userAnswer = Console.ReadLine();

				try
				{
					bool result = IsCorrect(userAnswer, answers[i]);

					if (result == true)
					{
						Console.WriteLine("Congratulations! Your answer is correct.");
					}
					else
					{
						Console.WriteLine($"Oops! The correct answer is {answers[i]}");
					}
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
			Console.WriteLine("quiee completed");
		}

		private static bool IsCorrect(string inputuser, string inputAnswer)
		{
			if (string.IsNullOrEmpty(inputuser))
			{
				throw new Exception("hey answer cannot be empty");
			}

			if (inputuser == inputAnswer)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

	}
}
