using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class openLinkScript : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    string vbName;
    // Start is called before the first frame update
    void Start()
    {
         //Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
 
        for (int i = 0; i < virtualButtonBehaviours.Length; i++)
            virtualButtonBehaviours[i].RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vbName = vb.VirtualButtonName;
        if (vbName == "AccountBtn")
        {
            Application.OpenURL("https://account.torontopubliclibrary.ca");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
