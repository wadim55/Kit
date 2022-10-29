using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorView : Element
{
  public GameObject _door;

  void OnCollisionEnter(Collision other)
  {
Event.EventDoor("Somebody is near door");
  }
}
