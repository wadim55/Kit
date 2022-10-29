using System;

public static class Event 
{
   public static Action<string> door;

   public static void EventDoor(string doorEvent)
   {

    door?.Invoke(doorEvent);
   }
}
