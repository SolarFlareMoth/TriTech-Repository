using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoCaves : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CaveLevel();
        }
    }
    private void CaveLevel()
    {
        SceneManager.LoadScene(2);
    }
}
