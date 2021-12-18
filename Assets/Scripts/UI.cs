using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private IntVar _score;
    
    
    public void UpdateScore()
    {
        GetComponent<Text>().text = _score.ToString();
    }
}
