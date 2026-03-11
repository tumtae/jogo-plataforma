using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 7f;
    public float jumpCutMultiplier = 0.5f;

    private Rigidbody rb;
    private Animator anim;
    private bool isGrounded;
    private SpriteRenderer sr;

    public Transform groundCheck;
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
        CheckGround();
        Jump();
    }

void Move()
{
    float move = Input.GetAxisRaw("Horizontal");

    rb.linearVelocity = new Vector3(move * speed, rb.linearVelocity.y, 0);

    anim.SetFloat("Speed", Mathf.Abs(move));

    if (move > 0)
        sr.flipX = false;

    if (move < 0)
        sr.flipX = true;
}

    void Jump()
    {
        // começa o pulo
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, 0);
        }

        // corta o pulo se soltar o botão
        if (Input.GetKeyUp(KeyCode.W) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier, 0);
        }
    }

    void CheckGround()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
    }
}