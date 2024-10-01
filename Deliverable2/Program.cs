/* Task: Write a program that asks the user their name and if they want to do the COIN FLIP CHALLENGE. If they want to, they will have ten rounds to guess if the program got heads or tails. Every correct guess will add 1 to their total. Once completed, display the total correct back to the user. 

 * The user’s name should be stored in a variable so you can reference it later.
 * The challenge should only run if the user agrees to it.
 * If the user doesn’t agree, call them a coward and end the program without doing the challenge.
 * The challenge should have five rounds.
 * During each round the program secretly picks a random number: 0 or 1
 * Ask the user for heads or tails. Compare it to the random number.
 * These won’t nicely compare. You will have to come up with how heads and tails relate to 0 and 1.
 * Each right answer adds one to the total.

 * First, ask the user, “What is your name?” Store their response in a variable called name. Then ask the user if they want to do the COIN FLIP CHALLENGE. If they type “No”, call them a coward and end the program. If they choose yes, the challenge begins.
*/


Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");

// Step 1: Ask for the user's name
Console.WriteLine("What is your name?");
string name = Console.ReadLine();  

// Step 2: Ask if they want to do the Coin Flip Challenge
Console.WriteLine($"Hello {name}, do you want to do the COIN FLIP CHALLENGE? (Yes or No)");
string response = Console.ReadLine().ToLower(); 

// Step 3: If the user says "No", call them a coward and end the program
if (response == "no")
{
    Console.WriteLine("You are a coward! Goodbye.");
    return;  // Exit the program
}
// Step 4: If the user agrees, proceed to the challenge
else if (response == "yes")
{
    Console.WriteLine("Great! Let's start the COIN FLIP CHALLENGE!\n");

    int score = 0;

    Random random = new();  // Create a Random object for generating random numbers

    // Step 5: Loop for 5 rounds
    for (int i = 1; i <= 5; i++)
    {
        // Generate a random number: 0 for heads, 1 for tails
        int coinFlip = random.Next(2);

        // Step 6: Ask the user to guess heads or tails
        Console.WriteLine("Heads or Tails?");
        string guess = Console.ReadLine().ToLower();

        // Step 7: Check if the guess is correct
        // "heads" is 0 and "tails" is 1
        if ((guess == "heads" && coinFlip == 0) || (guess == "tails" && coinFlip == 1))
        {
            // If the user guessed correctly, add to the score
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            // If the user guessed wrong
            Console.WriteLine("Wrong!");
        }
    }

    // Step 8: After the loop, print the final score
    Console.WriteLine($"\nThank you {name}. You got a score of {score}!");
}
else
{
    // If the user doesn't input "yes" or "no"
    Console.WriteLine("Invalid input. Goodbye.");
}