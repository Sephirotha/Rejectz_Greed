using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class ChangeSceneOnComplete : MonoBehaviour
{
    [HideInInspector] public ST_PuzzleDisplay ourPuzzle;
    public string nextSceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        ourPuzzle = GetComponent<ST_PuzzleDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ourPuzzle.Complete == true)
        {
            // Change our scene
            // SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);

            Fungus.Flowchart.BroadcastFungusMessage("puzzleDone");

        }

       // if (Input.GetMouseButtonDown(0))
        {
           // ourPuzzle.Complete = true;
        }
    }
}
