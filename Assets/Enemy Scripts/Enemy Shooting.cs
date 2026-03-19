using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public Transform player;

    public float shootCooldown = 1.5f;
    private float timer;

    void Update()
    {
        if (player == null) return;

        timer += Time.deltaTime;

        if (timer >= shootCooldown)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Vector2 direction = (player.position - firePoint.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.SetDirection(direction);
        bulletScript.targetTag = "Player";
    }
}