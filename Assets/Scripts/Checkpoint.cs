using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject offObject;
    public GameObject onObject;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        Guardarposição player = other.GetComponent<Guardarposição>();

        if (player != null && !activated)
        {
            player.SetCheckpoint(transform.position);

            activated = true;

            offObject.SetActive(false);
            onObject.SetActive(true);
        }
    }
}