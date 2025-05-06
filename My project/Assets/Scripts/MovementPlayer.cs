using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento
    public Rigidbody2D rb;       // Referência ao Rigidbody2D
   

    Vector2 movement; // Vetor de movimento
    private void Start()
    {
        rb.gravityScale = 0;
    }
    void Update()
    {
        // Entrada do teclado (Eixo horizontal e vertical)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Movimento aplicado ao Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
