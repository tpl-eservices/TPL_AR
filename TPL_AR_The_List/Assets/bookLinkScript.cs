using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class bookLinkScript : MonoBehaviour
{
    public void openLink()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        switch (name)
        {
            case "nailbiters_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=nailbiters");
                break;
            case "headspace_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=headspace");
                break;
            case "fantasy_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=fantasy");
                break;
            case "true_story_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=true_story");
                break;
            case "own_voices_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=ownvoices");
                break;
            case "science_fiction_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=science_fiction");
                break;
            case "resist_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=resist");
                break;
            case "comics_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=comics_and_manga");
                break;
            case "turning_points_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=turning_points");
                break;
            case "poetry_books":
                Application.OpenURL("https://www.torontopubliclibrary.ca/teens/the-list.jsp?category=poetry");
                break;
            default:
                Debug.Log("No link source detected...");
                break;
        }
    }
}
