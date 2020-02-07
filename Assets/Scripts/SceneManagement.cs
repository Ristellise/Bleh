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
    void Start()
    {

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

    public void ToPauseMenu()
    {
        SceneManager.LoadScene("PauseMenu");
    }

    public void ToExitGame()
    {
        //Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
