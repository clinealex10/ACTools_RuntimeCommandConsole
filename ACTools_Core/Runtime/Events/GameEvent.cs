using System.Collections.Generic;
using UnityEngine;

// Based on this GDC talk: https://www.youtube.com/watch?v=raQ3iHhE_Kk
[CreateAssetMenu(fileName = "New GameEvent", menuName = "GameEvent/GameEvent")]
public class GameEvent : ScriptableObject
{
    protected List<GameEventListener> listeners = new List<GameEventListener>();

    /// <summary> Adds a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to add. </param>
    public virtual void Register(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    /// <summary> Removes a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to remove. </param>
    public virtual void Unregister(GameEventListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }

    /// <summary> Invokes this GameEvent. </summary>
    public virtual void Invoke()
    {
        for (int index = listeners.Count - 1; index >= 0; --index)
        {
            listeners[index].OnEventRaised();
        }
    }
}