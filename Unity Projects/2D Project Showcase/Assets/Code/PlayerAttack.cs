using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerAttack : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed = 2f;
    private int shotCount;
    public TMP_Text shotText;
    

    private void Start()
    {
        shotCount = 20;

        shotText.text = "Ammo: " + shotCount; 
    }

    private void Update()
    {
        if (shotCount > 320)
        {
            shotCount = 320;
            shotText.text = "Ammo: " + shotCount;
        }
    }
    public void OnAttack()
    {
        if (shotCount > 0 && Time.timeScale >=0.1)
        {
            shotCount--;
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(shot, 5);

            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;

            Vector3 shootDir = mousePos - transform.position;
            shootDir.Normalize();
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
            shotText.text = "Ammo: " + shotCount;
            shot.transform.right = shootDir;
        }
        else
        {
            shotText.text = "Ammo: " + shotCount;
        }
    }

    public GameObject ammoPack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ammoPack") && shotCount <= 319)
        {
            shotCount += 30;
            shotText.text = "Ammo: " + shotCount;
        }
    }
}
