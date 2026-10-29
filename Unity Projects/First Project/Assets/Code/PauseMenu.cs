using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if we press the escape key, run the pause function
        //Keyboard.current. is how we access if a button was pressed
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            PauseGame();
        }
    }

    //create two functions
    //pause and resume
    //PAUSE: stop the game, make the pause menu visible
    public void PauseGame()
    {
        Time.timeScale = 0;
        //timeScale is a float!!!
        GetComponent<Canvas>().enabled = true;
    }
    //RESUME: unfreeze the game, make the pause menu invisible
    public void Resume()
    {
        Time.timeScale = 1;
        GetComponent<Canvas>().enabled = false;
    }

    //add a function to reload the level?
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //I want to add a function that loads the main menu?
    //we don't has ones!!!
    public void LoadMainMenu()
    {
        //we don't has one?
        SceneManager.LoadScene("MainMenu");
    }
    //CHALLENGE:
    //Create buttons for your main menu. Make  button to load Level 1 (playable scene)

    //Also, make a win scene. Make some sort of trigger to enter the win scene
    //on the win scene, make buttons on a canvas to load main menu
}
