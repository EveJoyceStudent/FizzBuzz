using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // FizzBuzz
            // Write a console application that prints the integers from 1 to 100 (inclusive). But:
            //   for multiples of three, print Fizz (instead of the number)
            //   for multiples of five, print Buzz (instead of the number)
            //   for multiples of both three and five, print FizzBuzz (instead of the number)
            
            Console.WriteLine("FizzBuzz");
            for(int i = 0; i < 100; i++){
                if ((i+1)%3==0){
                    if ((i+1)%5==0){
                        Console.WriteLine("FizzBuzz");
                    } else {
                        Console.WriteLine("Fizz");
                    }
                } else {
                    if ((i+1)%5==0){
                        Console.WriteLine("Buzz");
                    } else {
                        Console.WriteLine(i+1);
                    }
                }
                // to figure out my values i used
                // Console.WriteLine(i+" "+(i%3)+" "+(i%5));
            }
            // Console.WriteLine("loop finished");

            // Submission:
            // - Submit the link to your public Git Repo (Github or equivalent)
            // In the git repo include
            // - Psuedo Algorithm or Flowchart
            // - dotnet console app (i.e code)
            // - Screenshot of output (at least the last 15 lines)

            //in class tasks
            /*
            // for loops are great for counting
            // note i++ is equivalent to i = i+1

            // Task 1 - count to 10
            Console.Write("counter starting at 0: ");
            for(int i = 0; i < 10; i++){
                Console.Write(i+1+", ");
            }
            Console.WriteLine("loop finished");
            
            Console.Write("counter starting at 1: ");
            for(int i = 1; i <= 10; i++){
                Console.Write(i+", ");
            }
            Console.WriteLine("loop finished");

            Console.Write("while ");
            int j = 0;
            while(j < 10){
                Console.Write((j+1)+", ");
                j++;
            }
            Console.WriteLine("loop finished");

            // Task 2 - 0 to 20 by twos
            Console.Write("counter starting at 0: ");
            for(int i = 0; i <= 10; i++){
                Console.Write((2*i)+", ");
            }
            Console.WriteLine("loop finished");
            
            // task 3 A program that asks the user to guess a number. The magic number is 5. If they get it wrong, the program asks for the number again.
            string numberguess = "";
            bool correctguess = false;

            while(correctguess == false){
                Console.Write("Please guess a number: ");
                numberguess = Console.ReadLine();
                if(numberguess.ToLower()=="five"||numberguess=="5"){
                    correctguess = true;
                    Console.WriteLine("You guessed my number!");
                } else {
                    Console.WriteLine("You didn't guess my number!");
                }
            }
            //Task 4 A program that asks the user to enter a number. The program then counts from 0 to that number.
            int intNumberInput;
            Console.Write("Please enter a number: ");
            string NumberInput = Console.ReadLine();
            while(!int.TryParse(NumberInput, out intNumberInput))
            {
                Console.Write("Sorry, I didn't understand that, please enter number as a numeral: ");
                NumberInput = Console.ReadLine();
            }
            int k = 0;
            while(k<=intNumberInput){
                Console.Write(k+", ");
                k++;
            }
            Console.WriteLine("loop finished");

            // task 5 A program that asks the user "What happens when you throw a yellow rock in the red sea?". The user must guess the correct answer, "It gets wet". If the correct answer isn't entered the program asks again.

            string wetString = "";
            while(!(wetString.ToLower()=="it gets wet"))
            {
                Console.Write("What happens when you throw a yellow rock in the red sea? ");
                wetString = Console.ReadLine();
            }

            // Set a secret number to 653.  Then program will then loop, where each loop will ask the user to enter what they think a secret integer is. If they get it right, print "Correct", otherwise print "Wrong, counter value is ".  Give the user 10 chances to guess.   Hint: You will need an if statement inside the loop.  Bonus: Make the secret number randomly generate between 1 and 1000 each time the program is run.

            // generate random number
            var random = new Random();
            int num = random.Next(1,1000);
            // (so it's possible to guess the right number for testing)
            Console.WriteLine(num);

            // initate guess vars
            string guess;
            int intGuess;

            // initate loop
            int l = 0;
            while(l<10){
                l++;
                Console.Write("what's the secret number? ");
                guess = Console.ReadLine();
                //validate input
                while(!int.TryParse(guess, out intGuess))
                {
                    Console.Write("sorry, I didn't understand that, please enter number as a numeral: ");
                    NumberInput = Console.ReadLine();
                }
                //check for correct guess
                if(intGuess==num){
                    Console.WriteLine("You guessed the number!");
                    break;
                } else {
                    // if incorrect, tell user how many guesses left, or tell the correct answer if none left
                    if(l<10){
                        // to get the correct grammar on "guesses/guess"
                        if(l<9){
                            Console.WriteLine("sorry, not it, try again, "+(10-l)+" guesses remaining");
                        } else {
                            Console.WriteLine("sorry, not it, try again, "+(10-l)+" guess remaining");
                        }
                    } else {
                        Console.WriteLine("the secret number was "+num);
                    }
                }
            }
            */
        }
    }
}
