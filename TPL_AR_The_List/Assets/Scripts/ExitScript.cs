using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Exiting application...");
        Application.Quit();
    }
}
