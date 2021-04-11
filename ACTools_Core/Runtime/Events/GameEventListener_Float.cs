using UnityEngine;

[AddComponentMenu("ACTools/Event Listners/Game Event Listner - Float")]
public class GameEventListener_Float : MonoBehaviour
{
    [SerializeField] protected GameEvent_Float floatGameEvent = null;

    public FloatEvent Response;

    protected virtual void OnEnable()
    {
        floatGameEvent.Register(this);
    }

    protected virtual void OnDisable()
    {
        floatGameEvent.Unregister(this);
    }

    public virtual void OnEventRaised(float argument)
    {
        Response?.Invoke(argument);
    }
}