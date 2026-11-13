using UnityEngine;

public class ModeSelectManager : MonoBehaviour
{
    [SerializeField] GameObject modeSelectMenu;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject normalSelectMenu;

    public void ChooseBack1()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }

    public void ChooseNormal()
    {
        gameObject.SetActive(false);
        normalSelectMenu.SetActive(true);
    }
}
