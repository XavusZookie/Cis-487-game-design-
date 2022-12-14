using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listeners = new List<GameEventListener>();
    //Raise event through different methods signatures
    public void Raise()
    {
        //for (int i = listeners.Count - 1; i >= 0; i--)
        for (int i =0; i< listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }//manager listeners
    public void RegisterListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }
    public void UnregisterListener(GameEventListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
}
