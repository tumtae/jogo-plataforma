using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variável para controlar a velocidade do movimento
    public float speed = 5f;
    private Rigidbody rb; //referencia ao componente Rigidbody do personagem

    void Update()
    {
        rb = GetComponent<Rigidbody>(); //Obtém o componente Rigidbody do personagem
        //1. Captura do input do jogador (Teclas WASD ou setas)
        float moveZ = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, moveZ * speed); //Aplica o movimento no eixo Z
        rb.linearVelocity = new Vector3(rb.linearVelocity.x, moveY * speed, rb.linearVelocity.z); //Aplica o movimento no eixo Y
    
    }
}
