using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class libraryCardScript : MonoBehaviour
{
    public void openLink()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log("Opening account...");
        Debug.Log(name);
        Application.OpenURL("https://account.torontopubliclibrary.ca");
        switch (name)
            {
                case "Account Btn":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "Programs Btn":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/programs-and-classes/");
                    break;
                /*case "library_card":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_1":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_2":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_3":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_1_crop":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_2_crop":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;
                case "adult_library_card_3_crop":
                    Application.OpenURL("https://account.torontopubliclibrary.ca");
                    break;*/
                default:
                    Debug.Log("No link source detected...");
                    break;
            }
    }
}
