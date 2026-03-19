using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform player;

    public float shootCooldown = 1.5f;
    public float shootingRange = 8f;

    private float timer;

    void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= shootingRange)
        {
            timer += Time.deltaTime;

            if (timer >= shootCooldown)
            {
                Shoot();
                timer = 0f;
            }
        }
    }

    void Shoot()
    {
        Vector2 direction = (player.position - firePoint.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.SetDirection(direction);
        bulletScript.targetTag = "Player";
    }
}