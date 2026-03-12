using UnityEngine;

public class inimigo : MonoBehaviour
{
    public float repulsão = 5f;
    public GameObject inimigoObjeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, repulsão, rb.linearVelocity.z);
                Destroy(inimigoObjeto, 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
