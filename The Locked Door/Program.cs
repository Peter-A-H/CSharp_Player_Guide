var door = new Door(1234);
door.ChangePasscode(1234, 5555);

Console.WriteLine($"The door is currently {door.State}.");
door.Unlock();

public class Door(int passcode)
{
    public int Passcode { private get; set; } = passcode;
    public DoorState State { get; private set; } = DoorState.Closed;

    public void ChangePasscode(int currentPasscode, int newPasscode)
    {
        if (currentPasscode == Passcode)
        {
            Console.WriteLine($"Passcode changed from {Passcode} to {newPasscode}.");
            Passcode = newPasscode;
        }
        else
        {
            Console.WriteLine("The current passcode is not correct.");
        }
    }

    public void Open()
    {
        if (State == DoorState.Locked)
        {
            State = DoorState.Open;
            Console.WriteLine("The door is now open.");
        }
        else if (State == DoorState.Open)
        {
            Console.WriteLine("The door is already open.");
        }
        else
        {
            Console.WriteLine("Unable to open the door.");
        }
    }

    public void Close()
    {
        if (State == DoorState.Open)
        {
            State = DoorState.Closed;
            Console.WriteLine("The door is now closed.");
        }
        else if (State == DoorState.Closed)
        {
            Console.WriteLine("The door is already closed.");
        }
        else
        {
            Console.WriteLine("Unable to close the door.");
        }
    }

    public void Lock()
    {
        if (State == DoorState.Closed)
        {
            State = DoorState.Locked;
            Console.WriteLine("The door is now locked.");
        }
        else if (State == DoorState.Locked)
        {
            Console.WriteLine("The door is already locked.");
        }
        else
        {
            Console.WriteLine("Unable to lock the door.");
        }
    }

    public void Unlock()
    {
        if (State == DoorState.Locked)
        {
            State = DoorState.Unlocked;
            Console.WriteLine("The door is now unlocked.");
        }
        else if (State == DoorState.Closed)
        {
            Console.WriteLine("The door is already unlocked.");
        }
        else
        {
            Console.WriteLine("Unable to unlock the door.");
        }
    }
}

public enum DoorState { Locked, Closed, Open, Unlocked }