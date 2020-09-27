using System;
using UnityEngine.Events;

[Serializable]
public class StringEvent : UnityEvent<string> { };

[Serializable]
public class BoolEvent : UnityEvent<bool> { };

[Serializable]
public class IntEvent : UnityEvent<int> { };

[Serializable]
public class FloatEvent : UnityEvent<float> { };