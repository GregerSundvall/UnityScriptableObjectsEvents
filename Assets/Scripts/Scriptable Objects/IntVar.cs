using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntVar : ScriptableObject
{
    private int _value;

    public int GetInt()
    {
        return _value;
    }
    
    public string GetString()
    {
        return _value.ToString();
    }

    public void IncreaseWith(int amount)
    {
        _value += amount;
    }
    
    public void DecreaseWith(int amount)
    {
        _value -= amount;
    }
}
