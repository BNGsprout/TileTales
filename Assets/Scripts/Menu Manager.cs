using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject modeSelectMenu;
    [SerializeField] GameObject instructionsMenu;
    [SerializeField] GameObject whatsNewMenu;
    [SerializeField] GameObject creditsMenu;

    void Start()
    {
        
    }

    public void ChoosePlay()
    {
        SceneManager.LoadScene(1);
    }

    public void ChooseModeSelect()
    {
        gameObject.SetActive(false);
        modeSelectMenu.SetActive(true);
    }

    public void ChooseInstructions()
    {
        gameObject.SetActive(false);
        instructionsMenu.SetActive(true);
    }

    public void ChooseWhatsNew()
    {
        gameObject.SetActive(false);
        whatsNewMenu.SetActive(true);
    }

    public void ChooseCredits()
    {
        gameObject.SetActive(false);
        creditsMenu.SetActive(true);
    }
}
