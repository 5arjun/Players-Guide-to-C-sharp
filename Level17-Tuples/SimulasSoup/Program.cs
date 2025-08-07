using System;

enum Type { soup, stew, gumbo }
enum Main { mushroom, chicken, carrot, potato }
enum Seasoning { spicy, salty, sweet }

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        (Type type, Main main, Seasoning seasoning) dinner;

        // --- TYPE ---
        Console.WriteLine("What type of meal do you want? (soup, stew, gumbo)");

        while (true)
        {
            string typeInput = Console.ReadLine();
            if (Enum.TryParse(typeInput.ToLower(), out Type chosenType))
            {
                dinner.type = chosenType;
                break;
            }
            Console.WriteLine("Please enter a valid type: (soup, stew, gumbo)");
        }

        // --- MAIN INGREDIENT ---
        Console.WriteLine("What main ingredient do you want? (mushroom, chicken, carrot, potato)");

        while (true)
        {
            string mainInput = Console.ReadLine();
            if (Enum.TryParse(mainInput.ToLower(), out Main chosenMain))
            {
                dinner.main = chosenMain;
                break;
            }
            Console.WriteLine("Please enter a valid main ingredient: (mushroom, chicken, carrot, potato)");
        }

        // --- SEASONING ---
        Console.WriteLine("What seasoning do you want? (spicy, salty, sweet)");

        while (true)
        {
            string seasoningInput = Console.ReadLine();
            if (Enum.TryParse(seasoningInput.ToLower(), out Seasoning chosenSeasoning))
            {
                dinner.seasoning = chosenSeasoning;
                break;
            }
            Console.WriteLine("Please enter a valid seasoning: (spicy, salty, sweet)");
        }

        // --- RESULT ---
        Console.WriteLine($"\nYour meal: {dinner.seasoning} {dinner.main} {dinner.type}");
    }
}
