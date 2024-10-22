using UnityEngine;
using UnityEngine.UI;

public class WhiteHealth : MonoBehaviour
{

    [SerializeField] public float PlayerHealth;
    [SerializeField] public Slider HealthBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerHealth = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.value = PlayerHealth;


        if (PlayerHealth <= 0)
        {

            //UnityEditor.EditorApplication.isPlaying = false;g
            Application.Quit();
        }
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D coll)
    {
        if (coll.gameObject.tag == "BlackEnemy")
        {
            PlayerHealth = PlayerHealth - 1;
            Debug.Log(PlayerHealth);

        }
    }
}
