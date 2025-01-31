using System;

class GuessVal{
	static void Main(){
		Console.Write("Enter any Number between 1 to 100 : ");
		int inp = int.Parse(Console.ReadLine());
		
		int low=1, high=100;
		bool isCorrect = false;
		
		while(!isCorrect){
			int guess = GenerateGuess(low, high);
			Console.WriteLine("Is your Number "+guess+" ?");
			Console.WriteLine("Enter 'H' if my guess as too high, 'L' if its too low or 'C' if its correct.");
			
			char feedback = GetFeedback();
			
			if(feedback == 'C'){
				Console.WriteLine("I guessed your number correctly.");
				isCorrect = true;
			}
			else if(feedback == 'H'){
				high = guess - 1;
			}
			else if(feedback == 'L'){
				low = guess + 1;
			}
			if(low > high){
				Console.WriteLine("Something went wrong. Please restart the game and give correct feedback.");
				break;
			}
			
		}
		
	}
	static int GenerateGuess(int low, int high){
		Random random = new Random();
		return random.Next(low, high + 1);
	}
	static char GetFeedback(){
		char input;
		while(true){
			input = Char.ToUpper(Console.ReadKey().KeyChar);
			Console.WriteLine();
			
			if(input == 'H' || input == 'L' || input == 'C'){
				return input;
			}
			Console.WriteLine("Invalid Input.");
		}
	}
}