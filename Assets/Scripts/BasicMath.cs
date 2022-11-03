using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMath : MonoBehaviour
{
    public int a;
    public int b;
  
    // Start is called before the first frame update
    void Start()
    {
        

        Summe(a, b);
        Differenz(a, b);
        Produkt(a, b);
        Division(a, b);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Summe (int a, int b)
    {
        Debug.Log("Die Summe ist " + (a + b));
    }

    private void Differenz (int a, int b)
    {
        Debug.Log("Die Differenz ist " + (a - b));
    }

    private void Produkt (int a, int b)
    {
        Debug.Log("Das Produkt ist " + (a * b));
    }

    private void Division (int a, int b)
    {
        Debug.Log("Die Division ist " + (a / b));
    }
}
