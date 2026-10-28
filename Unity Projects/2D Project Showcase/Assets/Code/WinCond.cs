using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Win();
    }

    private void Win()
    {
        SceneManager.LoadScene(3);
    }
}
