using UnityEngine;

public class WhatsNewManager : MonoBehaviour
{
    [SerializeField] GameObject whatsNewMenu;
    [SerializeField] GameObject menu;

    public void ChooseBack1()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
