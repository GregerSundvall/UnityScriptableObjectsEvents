using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private IntVar _score;
    [SerializeField] private int pointsPerDestroy;

    [SerializeField] private GameEvent _scoreChangedEvent;
    
    
    public void Increase()
    {
        _score.IncreaseWith(pointsPerDestroy);
        Debug.Log("Invoking score changed...");
        _scoreChangedEvent.Invoke();
    }
    
    

}
