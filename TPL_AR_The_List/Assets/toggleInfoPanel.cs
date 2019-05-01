using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleInfoPanel : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
