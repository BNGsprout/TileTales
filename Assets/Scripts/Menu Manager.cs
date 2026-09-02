using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject instructionsMenu;
    [SerializeField] GameObject creditsMenu;

    void Start()
    {
        
    }

    public void ChoosePlay()
    {
        SceneManager.LoadScene(1);
    }

    public void ChooseInstructions()
    {
        gameObject.SetActive(false);
        instructionsMenu.SetActive(true);
    }

    public void ChooseCredits()
    {
        gameObject.SetActive(false);
        creditsMenu.SetActive(true);
    }
}
