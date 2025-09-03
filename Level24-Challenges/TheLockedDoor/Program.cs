public enum State { open, closed, locked };

public class Door
{
    public State state { get; set; } = State.open;
    private int code { get; set; }

    public Door(int initialCode) { code = initialCode; }

    private string buildErrorString(State neededState)
    {
        return $"Unable to {neededState}, door is currently {state}";
    }
    public string closeDoor()
    {
        if (state == State.open)
        {
            state = State.closed;
            return "Door successfully closed";
        }
        return buildErrorString(State.closed);
    }
    public string openDoor()
    {
        if (state == State.closed)
        {
            state = State.open;
            return "Door successfully opened";
        }
        return buildErrorString(State.open);
    }

    public string lockDoor()
    {
        if (state == State.closed)
        {
            state = State.locked;
            return "Door successfully locked";

        }
        return buildErrorString(State.locked);
    }

    public string unlockDoor(int code)
    {
        if (this.code == code && state == State.locked)
        {
            state = State.closed;
            return "Door successfully unlocked";
        }
        return "Wrong code provided or door is not currently locked.";
    }
    public string changeCode(int currentCode, int newCode)
    {
        if (this.code == currentCode)
        {
            this.code = newCode;
            return "the code has successfully been changed";
        }
        return "The initial code provided is incorrect.";
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a passcode for ur door: ");
        int chosenCode = Convert.ToInt32(Console.ReadLine());
        Door userDoor = new Door(chosenCode);
        while (true)
        {

            Console.WriteLine("What action do u want to take: Open, Close, Lock, Unlock, or Change code");

            string chosenAction = Console.ReadLine().ToLower();
            switch (chosenAction)
            {
                case "open":
                    Console.WriteLine(userDoor.openDoor());
                    break;
                case "close":
                    Console.WriteLine(userDoor.closeDoor());
                    break;
                case "lock":
                    Console.WriteLine(userDoor.lockDoor());
                    break;
                case "unlock":
                    Console.Write("Please enter the code: ");
                    int code = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userDoor.unlockDoor(code));
                    break;
                case "change code":
                    Console.Write("Provide the current code first: ");
                    int currentCode = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Now enter the new code: ");
                    int newCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(userDoor.changeCode(currentCode, newCode));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}