using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InfoText : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI infoText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 1)
        {
            
            infoText.text = "Press A/SPACE to jump.";
            
        }
        else if (currentSceneIndex == 2)
        {
            
            infoText.text = "Press X/E to shoot.";
        }
        else if (currentSceneIndex == 3)
        {
            infoText.text = "Jump on mushrooms to bounce progressively higher.";
        }
        else if (currentSceneIndex == 4)
        {
            infoText.text = "Watch out for secret vertical ladders.";
        }
        else if (currentSceneIndex == 5)
        {
            // Change this to only tell how to super jump; a limit will be explained in level 6.
            infoText.text = "Press Y/ALT to do a Super Jump.";
        }
        else if (currentSceneIndex == 6)
        {
            infoText.text = "super Jumps have a cool-down of 15 seconds.";
        }
        else if (currentSceneIndex == 7)
        {
            infoText.text = "You finished the game! More levels coming soon!";
        }

    }

    

}
