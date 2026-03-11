using UnityEngine;

public class KillObstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Guardarposição player = other.GetComponent<Guardarposição>();

            if (player != null)
            {
                player.Respawn();
            }
        }
    }
}