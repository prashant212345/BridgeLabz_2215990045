using System;
class CheckNum{
	Static void Main(){
		// Define an integer array to store 5 numbers
        int[] num = new int[5];
		Console.WriteLine("Enter any 5 numbers : ");
		
		// Input loop to store numbers in the array
		for(int i=0; i<num.Length; i++){
			num[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i=0; i<num.Length; i++){
			if(num[i] > 0){
				if(num[i] % 2 == 0){
					Console.WriteLine(num[i] +"is a Positive Even Number.");
				}else{
					Console.WriteLine(num[i] +"is a Positive Odd Number.");
				}
			}else if(num[i] < 0){
				Console.WriteLine(num[i]+" is a Negative Number");
			}else{
				Console.WriteLine(num[i]+" is a Zero");
			}
		}
	}
}