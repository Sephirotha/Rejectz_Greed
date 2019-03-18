using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusInteraction : MonoBehaviour {

    public GameObject GO_thePlayer;
    public float fl_minTriggerDistance;
    public string st_fungusMessage = "";

   void Update()
    {
        float currentDistance = Vector3.Distance(this.transform.position, GO_thePlayer.transform.position);

        print(currentDistance);

        if (currentDistance <= fl_minTriggerDistance)
        {
            print("Test");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Fungus.Flowchart.BroadcastFungusMessage(st_fungusMessage);
            }
        }
    }
}
