using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerGroundCheck))]
public class PlayerMovement : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 7f;

    [Header("Salto")]
    public float jumpImpulse = 10f;   // prueba entre 6 y 12

    Rigidbody2D rb;
    PlayerGroundCheck groundCheck;
    float moveX;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        groundCheck = GetComponent<PlayerGroundCheck>();
    }

    void Update()
    {
        // Input lateral (viejo Input Manager)
        moveX = Input.GetAxisRaw("Horizontal");

        // Saltar
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.isGrounded)
        {
            // opcional: resetea la velocidad vertical para saltos consistentes
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f);

            rb.AddForce(Vector2.up * jumpImpulse, ForceMode2D.Impulse);
            Debug.Log("¡Salto!");
        }
    }

    void FixedUpdate()
    {
        // Movimiento en X por velocidad
        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y);
    }
}
