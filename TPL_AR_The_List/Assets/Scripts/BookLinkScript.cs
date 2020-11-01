using UnityEngine.EventSystems;
using UnityEngine;

public class BookLinkScript : MonoBehaviour
{
    public string URL;

    public void OpenLink()
    {
        try
        {
            Application.OpenURL(URL);
        }
        catch
        {
            Debug.Log("No link source detected...");
        }
    }
}
