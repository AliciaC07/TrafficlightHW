using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour
{
    public float time = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
       
        
    }

    
    public void OnvalueChanged(float value)
    {
        time = value;
        Time.timeScale = time;
    }
}
