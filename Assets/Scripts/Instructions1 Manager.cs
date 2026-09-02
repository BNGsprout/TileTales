using UnityEngine;

public class Instructions1Manager : MonoBehaviour
{
    [SerializeField] GameObject instructionsMenu;
    [SerializeField] GameObject menu;

    public void ChooseBack1()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }
}
