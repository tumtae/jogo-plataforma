using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour
{
    Vector3 startPosition;
    Rigidbody rb;

    public float shakeTime = 1f;
    public float respawnTime = 3f;

    bool activated = false;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;
        rb.useGravity = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!activated && collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FallSequence());
        }
    }

    IEnumerator FallSequence()
    {
        activated = true;

        float timer = 0;

        while (timer < shakeTime)
        {
            transform.position = startPosition + Random.insideUnitSphere * 0.05f;
            timer += Time.deltaTime;
            yield return null;
        }

        transform.position = startPosition;

        rb.isKinematic = false;
        rb.useGravity = true;

        yield return new WaitForSeconds(respawnTime);

        ResetPlatform();
    }

    void ResetPlatform()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.position = startPosition;

        rb.isKinematic = true;
        rb.useGravity = false;

        activated = false;
    }
}