public enum State { open, closed, locked };

public class Door
{
    public State state { get; set; } = State.open;
    private string code { get; set; }

    public Door(string initialCode) { code = initialCode; }

    public void closeDoor() { if (state == State.open) state = State.closed; }
    public void openDoor() { if (state == State.closed) state = State.open; }

    public void lockDoor() { if (state == State.locked) state = State.Locked; }

    public void unlockDoor(string code) { if (this.code == code && state == State.locked) state = State.closed; }

    public void changeCode(string currentCode, string newCode)
    {
        if (this.code == currentCode) this.code = newCode;
    }
}
