using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalSelectManager : MonoBehaviour
{
    [SerializeField] GameObject normalSelectMenu;
    [SerializeField] GameObject menu;

    public void ChooseBack1()
    {
        gameObject.SetActive(false);
        menu.SetActive(true);
    }

    public void Choose1()
    {
        SceneManager.LoadScene(1);
    }

    public void Choose2()
    {
        SceneManager.LoadScene(2);
    }

    public void Choose3()
    {
        SceneManager.LoadScene(3);
    }

    public void Choose4()
    {
        SceneManager.LoadScene(4);
    }

    public void Choose5()
    {
        SceneManager.LoadScene(5);
    }

    public void Choose6()
    {
        SceneManager.LoadScene(6);
    }

    public void Choose7()
    {
        SceneManager.LoadScene(7);
    }

    public void Choose8()
    {
        SceneManager.LoadScene(8);
    }

    public void Choose9()
    {
        SceneManager.LoadScene(9);
    }
}
