using UnityEngine;

[AddComponentMenu("ACTools/Event Listners/Game Event Listner - String")]
public class GameEventListener_String : MonoBehaviour
{
    [SerializeField] protected GameEvent_String stringGameEvent = null;

    public StringEvent Response;

    protected virtual void OnEnable()
    {
        stringGameEvent.Register(this);
    }

    protected virtual void OnDisable()
    {
        stringGameEvent.Unregister(this);
    }

    public virtual void OnEventRaised(string argument)
    {
        Response?.Invoke(argument);
    }
}