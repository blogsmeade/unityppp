using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BackgroundSound : MonoBehaviour
{
    private AudioSource Background;
    // Start is called before the first frame update
    void Start()
    {
        Background = GetComponent<AudioSource>();
        Background.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
