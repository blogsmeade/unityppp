using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    float Zwischenzeit;
    float Sekunde = 1;
    float Ergebnis;
    
    void Start()
    {
        FixedUpdate();
        Debug.Log(Ergebnis);
    }

    private void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime);
        Zwischenzeit = Time.deltaTime;
        Ergebnis = Sekunde / Zwischenzeit;
        
    }
}
