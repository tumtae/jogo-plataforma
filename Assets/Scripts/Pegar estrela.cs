using UnityEngine;

public class StarCollect : MonoBehaviour
{
    public Uiestrela ui;
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
            ui.AddStar();
            audioSource.Play();
        }
    }
}