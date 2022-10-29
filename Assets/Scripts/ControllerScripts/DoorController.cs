using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : Element
{
   private void OnEnable()
   {
    Event.door += OpenDoor;
   }

   private void OnDisable()
   {
    Event.door -= OpenDoor;
   }

   private void OpenDoor(string doorEvent)
   {
    var DoorState = app.model.doorModel;
    DoorState = new DoorModel();
     DoorState.openDoor = true;
    app.view.doorView1._door1.GetComponent<Animator>().enabled = true;
   }
}
