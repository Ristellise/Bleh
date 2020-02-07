using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarageSelect : MonoBehaviour
{
    //Changes c = Changes.Campaign;
    // Start is called before the first frame update
    UnityEngine.UI.Text btl;
    public GameObject[] l;
    void Start()
    {
        btl = transform.Find("mainb/Text").GetComponent<UnityEngine.UI.Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
        btl.text = GlobalSwitchState.current.ToString().Replace("_"," ");
    }

    public void changeScene()
    {
        if (GlobalSwitchState.current + 1 == Changes.Count)
        {
            GlobalSwitchState.current = Changes.Campaign;
            for (int i = 0; i < l.Length; i++)
            {
                l[i].SetActive(false);
            }
            l[(int)GlobalSwitchState.current].SetActive(true);
        }
        else
        {
            GlobalSwitchState.current++;

            for (int i = 0; i < l.Length; i++)
            {
                l[i].SetActive(false);
            }
            l[(int)GlobalSwitchState.current].SetActive(true);

        }
    }


}

public static class Garage
{

}