using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSfx;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        Debug.Log("¡Moneda recogida!");
        if (pickupSfx != null)
            AudioSource.PlayClipAtPoint(pickupSfx, transform.position);

        Destroy(gameObject);
    }
}
