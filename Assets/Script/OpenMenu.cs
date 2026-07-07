using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menu;

    public void Open()
    {
        menu.SetActive(true);
    }
}
