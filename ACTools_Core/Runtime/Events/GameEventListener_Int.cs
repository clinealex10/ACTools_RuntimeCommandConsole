using UnityEngine;

[AddComponentMenu("ACTools/Event Listners/Game Event Listner - Int")]
public class GameEventListener_Int : MonoBehaviour
{
    [SerializeField] protected GameEvent_Int intGameEvent = null;

    public IntEvent Response;

    protected virtual void OnEnable()
    {
        intGameEvent.Register(this);
    }

    protected virtual void OnDisable()
    {
        intGameEvent.Unregister(this);
    }

    public virtual void OnEventRaised(int argument)
    {
        Response?.Invoke(argument);
    }
}