using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LibraryCardScript : MonoBehaviour
{
    public void OpenLink()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
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
                case "listBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp");
                    break;
                case "agincourtBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/agincourt/");
                    break;
                case "scarboroughBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/scarborough/");
                    break;
                case "albionBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/albion/");
                    break;
                case "northyorkBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/northyorkcentral/");
                    break;
                case "downsviewBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/downsview/");
                    break;
                case "richviewBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/richview/");
                    break;
                case "trlBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/torontoreferencelibrary/");
                    break;
                case "fortyorkBtnIconTrigger":
                    Application.OpenURL("https://www.torontopubliclibrary.ca/fortyork/");
                    break;
            default:
                    Debug.Log("No link source detected...");
                    break;
            }
    }
}
