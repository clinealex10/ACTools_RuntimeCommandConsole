using UnityEngine;
using UnityEngine.Events;

// Based on this GDC talk: https://www.youtube.com/watch?v=raQ3iHhE_Kk
[AddComponentMenu("ACTools/Event Listners/Game Event Listner")]
public class GameEventListener : MonoBehaviour
{
    [SerializeField] protected GameEvent gameEvent = null;

    public UnityEvent Response;

    protected virtual void OnEnable()
    {
        gameEvent.Register(this);
    }

    protected virtual void OnDisable()
    {
        gameEvent.Unregister(this);
    }

    public virtual void OnEventRaised()
    {
        Response?.Invoke();
    }
}