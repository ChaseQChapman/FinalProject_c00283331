using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        PlayerHealth.health = 100;
        PlayerHealth.points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void PlayFirstPerson()
    {
        SceneManager.LoadScene("FPGame");
        SceneManager.LoadScene("MainGame", LoadSceneMode.Additive);
       
    }

    public void PlayThirdPerson()
    {
        SceneManager.LoadScene("TPGame");
        SceneManager.LoadScene("MainGame", LoadSceneMode.Additive);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
