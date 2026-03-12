using UnityEngine;

public class Paredequesemove : MonoBehaviour
{
    
    public Transform alvoParede;
    Vector3 posição_inicial_parede;
    public float speed = 5f;
    bool foi = false;
    private Animator anim;
    private SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posição_inicial_parede = transform.position;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!foi)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                alvoParede.position,
                speed * Time.deltaTime
            );
            sr.flipX = true;
            
        }
        if (transform.position == alvoParede.position)
        {
            foi = true;
        }
        if(foi)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                posição_inicial_parede,
                speed * Time.deltaTime
            );
                sr.flipX = false;
            
        }
        if(transform.position == posição_inicial_parede)
        {
            foi = false;
        }

    }
}
