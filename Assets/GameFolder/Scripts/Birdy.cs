using UnityEngine;

public class Birdy : MonoBehaviour
{
    [SerializeField] float velocity = 1f;
    [SerializeField] GameObject DeathScreen;

    public GameManager manager;

    private Rigidbody2D rb;
    AudioSource audioSource;
    private bool isDead;
    private void Awake()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isDead == false)
        {
            rb.gravityScale = 1f;
            rb.linearVelocity = Vector2.up * velocity;
            audioSource.Play();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ScorArea"))
        {
            manager.ScoreUptade();
            collision.gameObject.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.CompareTag("DeathArea"))
        {
            isDead = true;
            DeathScreen.SetActive(true);
            Time.timeScale = 0f;
            manager.GameOver();
            collision.gameObject.GetComponent<AudioSource>().Play();
        }
    }
    public bool GetIsDead()
    { return isDead; }
}
