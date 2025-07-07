// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
func(State.closed, "open");


void func (State state, string action)
{
    switch (action)
    {
        case "close":
            if (state == State.open)
            {
                state = State.closed;
                Console.WriteLine("The door is now closed. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }

            else
            {
                Console.WriteLine($"The door is open. You cannot {action} it. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            break;
        case "open":
            if (state == State.closed)
            {
                state = State.open;
                Console.WriteLine("The door is now open. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            else
            {
                Console.WriteLine($"The door is {state}. You cannot {action} it. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            break;
        case "lock":
            if (state == State.closed)
            {
                state = State.locked;
                Console.WriteLine("The door is now locked. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            else
            {
                Console.WriteLine($"The door is {state}. You cannot {action} it. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            break;
        case "unlock":
            if (state == State.locked)
            {
                state = State.closed;
                Console.WriteLine("The door is now unlocked. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            else
            {
                Console.WriteLine($"The door is {state}. You cannot {action} it. What do you want to do? ");
                string nextAction = Console.ReadLine();
                func(state, nextAction);
            }
            break;
    }
}
enum State {open, closed, locked}