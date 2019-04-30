using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("Exiting application...");
        Application.Quit();
    }
}
