using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{

    private int currentScene;
    private int lastScene;
    private bool sceneTransition;
    // Start is called before the first frame update
    public GameObject pauseCanvas;
    void Start()
    {
        Debug.Log(pauseCanvas);
    }

    // Update is called once per frame
    void Update()
    {
        //if (lastScene == 2)
        //{
        //    SceneManager.LoadScene("InGame");
        //}
        //else
        //{
        //    SceneManager.LoadScene("MainMenu");
        //}
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ToOptions1()
    {
        SceneManager.LoadScene("Options1");
    }

    public void ToOptions2()
    {
        GlobalSwitchState.isPaused = false;
        SceneManager.LoadScene("Options2");
    }

    public void ToMapSelect()
    {
        SceneManager.LoadScene("MapSelection");
    }

    public void ToInGame()
    {
        SceneManager.LoadScene("InGame");
    }

    public void ToGarageSelect()
    {
        SceneManager.LoadScene("GarageSelect");
    }

    public void iPause()
    {
        if (pauseCanvas.activeInHierarchy)
        {
            GlobalSwitchState.isPaused = false;
            pauseCanvas.SetActive(false);
        }
        else
        {
            GlobalSwitchState.isPaused = true;
            pauseCanvas.SetActive(true);
        }
            
    }

    public void ToCarSelect()
    {
        SceneManager.LoadScene("CarSelect");
    }

    public void ToExitGame()
    {
        

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}
