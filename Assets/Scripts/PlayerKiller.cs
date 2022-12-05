using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerKiller : MonoBehaviour
{ 
    public int targetSceneIndex = 0;
    public string targetSceneName = "SCENE_Game";

   private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.CompareTag ("Player"))
        {
            SceneManager.LoadScene(0); 
            Debug.Log("Neu");
        }
        }       
    
               


}
