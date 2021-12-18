using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroyer : MonoBehaviour
{
    [SerializeField] private GameEvent _boxDestroyed;
    
    private void OnMouseDown()
    {
        _boxDestroyed.Invoke();
        
        Destroy(gameObject);
    }
}
