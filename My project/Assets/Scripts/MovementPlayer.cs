using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField]public float moveSpeed = 5f; // Velocidade de movimento
    [SerializeField] private float runSpeed = 10f; // Corrida
    [SerializeField] private float speed; // Velocidade atual do player
    public Rigidbody2D rb;
    [SerializeField] Animator anim;


    Vector2 movement;

    public float Speed { get => speed; set => speed = value; }

    private void Start()
    {
        rb.gravityScale = 0;
        speed = moveSpeed;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        // Entrada do teclado (Eixo horizontal e vertical)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire3"))
        {
            speed = runSpeed;
        }
        if (Input.GetButtonUp("Fire3"))
        {
            speed = moveSpeed;
        }
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Movimento aplicado ao Rigidbody2D
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
