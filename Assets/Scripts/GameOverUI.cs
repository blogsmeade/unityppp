using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        DisableUI();
    }
    public void EnableUI()
    {
        UI.SetActive(true);
    }
    public void DisableUI()
    {
        UI.SetActive(false);
    }
    public void RestartGame ()
    {

        var currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
        
    }
}
