﻿using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] protected GameEvent _gameEvent;
    [SerializeField] protected UnityEvent _unityEvent;

    void Awake() => _gameEvent.Register(this);

    void OnDestroy() => _gameEvent.Deregister(this);

    public virtual void RaiseEvent() => _unityEvent.Invoke();
}