namespace P3LevelUpp;

public class House
{
   private bool isDoorOpen;

    public void OpenDoor()
    {
        isDoorOpen = true;
    }

    public void CloseDoor()
    {
        isDoorOpen = false;
    }

    public bool IsDoorOpen()
    {
        return isDoorOpen;
    }
    
}