using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject VBButtonObject;
    // Start is called before the first frame update
    void Start()
    {
        VBButtonObject = GameObject.Find("RotateCat");
        VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Not Pressed");
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
