using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    public bool isGrounded { get; private set; }
    [SerializeField] private string groundTag = "Ground";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(groundTag))
        {
            isGrounded = true;
            Debug.Log("Jugador tocó el suelo");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(groundTag))
        {
            isGrounded = false;
            Debug.Log("Jugador dejó el suelo");
        }
    }
}
