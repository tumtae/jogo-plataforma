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
            ui.AddStar();
            audioSource.Play();
            Destroy(gameObject, 0.5f);
        }
    }
}