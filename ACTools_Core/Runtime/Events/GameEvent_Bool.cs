using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bool GameEvent", menuName = "GameEvent/GameEvent - Bool")]
public class GameEvent_Bool : ScriptableObject
{
    protected List<GameEventListener_Bool> listeners = new List<GameEventListener_Bool>();

    /// <summary> Adds a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to add. </param>
    public virtual void Register(GameEventListener_Bool listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    /// <summary> Removes a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to remove. </param>
    public virtual void Unregister(GameEventListener_Bool listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }

    /// <summary> Invokes this GameEvent. </summary>
    /// <param name="argument"> Argument to pass through from the event. </param>
    public virtual void Invoke(bool argument)
    {
        for (int index = listeners.Count - 1; index >= 0; --index)
        {
            listeners[index].OnEventRaised(argument);
        }
    }
}