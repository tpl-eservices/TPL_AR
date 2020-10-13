using UnityEngine;

public class ToggleInfoPanel : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
}
