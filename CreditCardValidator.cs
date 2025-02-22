using System;
using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public static void Main(string[] args)
    {
        string visaCard = "4123456789012345";
        string masterCard = "5123456789012345";
        string invalidCard = "6123456789012345";

        Console.WriteLine(ValidateCreditCard(visaCard));           
        Console.WriteLine(ValidateCreditCard(masterCard));         
        Console.WriteLine(ValidateCreditCard(invalidCard));        
    }

    public static string ValidateCreditCard(string cardNumber)
    {
        Regex cardRegex = new Regex(@"^(4\d{15}|5\d{15})$");

        if (cardRegex.IsMatch(cardNumber))
        {
            return "Valid";
        }
        else
        {
            return "Invalid";
        }
    }
}