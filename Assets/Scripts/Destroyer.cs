using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private GameEvent _onClicked;
    
    private void OnMouseDown()
    {
        _onClicked.Invoke();
        Destroy(gameObject);
    }
}
