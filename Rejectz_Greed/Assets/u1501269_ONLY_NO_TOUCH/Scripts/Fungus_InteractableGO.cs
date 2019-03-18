using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class Fungus_InteractableGO : MonoBehaviour {

    public Flowchart Fungus_Flowchart;
    public string OnMouseDownMessage;

    private void OnMouseDown()
    {
        if (!string.IsNullOrEmpty(OnMouseDownMessage))
        {
            Fungus_Flowchart.SendFungusMessage(OnMouseDownMessage);

            Debug.Log("Clicked!");
        }
    }
}
