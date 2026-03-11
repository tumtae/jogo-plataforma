using UnityEngine;

public class Guardarposição : MonoBehaviour
{
    private Vector3 respawnPoint;
    private Rigidbody rb;

    public float voidY = -10f;

    void Start()
    {
        respawnPoint = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < voidY)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        rb.linearVelocity = Vector3.zero;
        transform.position = respawnPoint;
    }

    public void SetCheckpoint(Vector3 newCheckpoint)
    {
        respawnPoint = newCheckpoint;
    }
}