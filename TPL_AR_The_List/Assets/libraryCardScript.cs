using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class libraryCardScript : MonoBehaviour
{
    public void openLink()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Application.OpenURL("https://account.torontopubliclibrary.ca");
        switch (name)
            {
                case "Account Btn":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "Programs Btn":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/programs-and-classes/");
                    break;
                case "Home Btn":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/");
                    break;
                case "Branches Btn":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/branches/");
                    break;
                default:
                    Debug.Log("No link source detected...");
                    break;
            }
    }
}
