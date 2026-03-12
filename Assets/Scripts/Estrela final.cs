using UnityEngine;

public class Estrelafinal : MonoBehaviour
{
    public Telafimdejogo fim;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject, 0);
            audioSource.Play();
            fim.MostrarTexto();
        }
    }
}