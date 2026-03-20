using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public float lifetime = 3f;
    public string targetTag;

    private Vector2 direction;
    private Rigidbody2D rb;
    private bool hasHit = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;
    }

    void Start()
    {
        rb.linearVelocity = direction * speed;
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasHit) return;

        if (collision.CompareTag("Wall"))
        {
            hasHit = true;
            Destroy(gameObject);
            return;
        }

        if (collision.CompareTag(targetTag))
        {
            hasHit = true;

            EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }

            PlayerHealth playerHealth = collision.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }
}