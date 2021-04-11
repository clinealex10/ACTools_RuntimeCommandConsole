using UnityEngine;

[AddComponentMenu("ACTools/Event Listners/Game Event Listner - Bool")]
public class GameEventListener_Bool : MonoBehaviour
{
    [SerializeField] protected GameEvent_Bool boolGameEvent = null;

    public BoolEvent Response;

    protected virtual void OnEnable()
    {
        boolGameEvent.Register(this);
    }

    protected virtual void OnDisable()
    {
        boolGameEvent.Unregister(this);
    }

    public virtual void OnEventRaised(bool argument)
    {
        Response?.Invoke(argument);
    }
}