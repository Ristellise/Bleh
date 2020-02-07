using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GarageSelect : MonoBehaviour
{
    //Changes c = Changes.Campaign;
    // Start is called before the first frame update
    UnityEngine.UI.Text btl;
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
        }
        else
            GlobalSwitchState.current++;
    }


}

public static class Garage
{

}