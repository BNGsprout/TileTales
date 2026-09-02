using UnityEngine;

public class CreditsMenuManager : MonoBehaviour
{
    [SerializeField] GameObject creditsMenu;
    [SerializeField] GameObject menu;

    public void ChooseBack1()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
