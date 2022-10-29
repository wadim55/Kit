using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorView1 : Element
{
     public GameObject _door1;

  void OnMouseDown()
  {
Event.EventDoor("Somebody is near door");
  }
}
