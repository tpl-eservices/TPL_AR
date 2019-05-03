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
                case "homeBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/");
                    break;
                case "accountBtnIconTrigger":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "programsBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/programs-and-classes/");
                    break;
                case "branchesBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/branches/");
                    break;
                default:
                    Debug.Log("No link source detected...");
                    break;
            }
    }
}
