using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private IntVar _score;
    
    
    public void UpdateScore()
    {
        Debug.Log("UI/Updatescore run");
        GetComponent<Text>().text = _score.ToString();
    }
}
