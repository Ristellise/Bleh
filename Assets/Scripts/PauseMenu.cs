using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButton;
    public Sprite buttonEnable;
    public Sprite buttonDisable;

    //void Start()
    //{
    //    pauseButton = GetComponent<Button>();
    //    pauseButton.interactable = false;
    //}

    public void onPauseClick()
    {
        bool isPressed = true;
        if (isPressed == true)
        {
            pauseButton.SetActive(false);
            pauseButton.GetComponent<Image>().sprite = buttonEnable;
            Debug.Log("The button has been enabled via the script!");
        }
        else
        {
            pauseButton.SetActive(true);
            pauseButton.GetComponent<Image>().sprite = buttonDisable;
            Debug.Log("The button is remaining disabled via the script!");
        }
    }
}
