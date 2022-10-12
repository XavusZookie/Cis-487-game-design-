using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameEvent gameEvent;

    public UnityEvent response;
    //allows you to link method calls directly in the editor

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }
    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }
    public void OnEventRaised()//Called by the game event when an event is broadcast
    {
        response.Invoke();
    }
}
