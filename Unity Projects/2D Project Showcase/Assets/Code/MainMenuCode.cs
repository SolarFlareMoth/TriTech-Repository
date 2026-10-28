using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void closeGame()
    {
        //put a way to close the game here, ask later
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
