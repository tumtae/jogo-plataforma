using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveZ = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(0f, moveY, moveZ); // Para 2D
        // Para 3D, use: new Vector3(moveX, 0f, moveY);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
