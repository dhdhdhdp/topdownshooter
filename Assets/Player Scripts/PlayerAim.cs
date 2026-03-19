using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    private void Update()
    {
        /// muis in game positie omzetten
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        /// richting van speler naar muis berekenen
        Vector2 direction = mouse - transform.position;

        ///richting zetten in een hoek(rotatie)
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        /// Draait de speler naar die hoek
        transform.rotation = Quaternion.Euler(0, 0, angle -90);
    }
}