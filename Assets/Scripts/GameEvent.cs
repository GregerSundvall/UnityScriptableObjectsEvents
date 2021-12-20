using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent", fileName = "GameEvent", order = 51)]
public class GameEvent : ScriptableObject
{
    private HashSet<GameEventListener> _listeners = new HashSet<GameEventListener>();
    
    public void Invoke()
    {
        Debug.Log($"Game event {this.name} invoked");
        foreach (var listener in _listeners)
        {
            listener.RaiseEvent();
        }
    }

    public void Register(GameEventListener listener) => _listeners.Add(listener);

    public void Deregister(GameEventListener listener) => _listeners.Remove(listener);
}