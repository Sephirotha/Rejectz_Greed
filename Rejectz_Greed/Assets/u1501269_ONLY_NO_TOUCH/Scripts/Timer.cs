using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

[EventHandlerInfoAttribute("Timers",
                            "Simple Timer",
                            "Executes the block after an amount of time has elasped")]
public class Timer : EventHandler
{
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("TimerExpired", duration);
    }

    void TimerExpired ()
    {
        ExecuteBlock();
            }
  
}
