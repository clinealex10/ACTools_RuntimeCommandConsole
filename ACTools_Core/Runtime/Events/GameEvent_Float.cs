using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float GameEvent", menuName = "GameEvent/GameEvent - Float")]
public class GameEvent_Float : ScriptableObject
{
    protected List<GameEventListener_Float> listeners = new List<GameEventListener_Float>();

    /// <summary> Adds a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to add. </param>
    public virtual void Register(GameEventListener_Float listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }

    /// <summary> Removes a listener to this GameEvent. </summary>
    /// <param name="listener"> Listener to remove. </param>
    public virtual void Unregister(GameEventListener_Float listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }

    /// <summary> Invokes this GameEvent. </summary>
    /// <param name="argument"> Argument to pass through from the event. </param>
    public virtual void Invoke(float argument)
    {
        for (int index = listeners.Count - 1; index >= 0; --index)
        {
            listeners[index].OnEventRaised(argument);
        }
    }
}