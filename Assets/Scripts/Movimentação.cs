using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocidade = 6f;
    public float Forçapulo = 7f;
    public float Cortarpulo = 0.5f;

    private Rigidbody rb;
    private Animator anim;
    private bool estanochao;
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
        Movimento();
        CheckGround();
        Pulo();
    }

void Movimento()
{
    float move = Input.GetAxisRaw("Horizontal");

    rb.linearVelocity = new Vector3(move * Velocidade, rb.linearVelocity.y, 0);

    anim.SetFloat("Speed", Mathf.Abs(move));

    if (move > 0)
        sr.flipX = false;

    if (move < 0)
        sr.flipX = true;
}

    void Pulo()
    {
        // começa o pulo
        if (Input.GetKeyDown(KeyCode.W) && estanochao)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, Forçapulo, 0);
        }

        // corta o pulo se soltar o botão
        if (Input.GetKeyUp(KeyCode.W) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y * Cortarpulo, 0);
        }
    }

    void CheckGround()
    {
        estanochao = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
    }
}