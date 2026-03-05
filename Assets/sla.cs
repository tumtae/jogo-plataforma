using UnityEngine;

public class sla : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            this.transform.Translate(0, 0, 0.05f);
        }
        if (Input.GetKey("a"))
        {
            this.transform.Translate(0, 0, -0.05f);
        }
        if (Input.GetKey("w"))
        {
            this.transform.Translate(0, 0.05f, 0);
        }

        Physics.CheckSphere(transform.position, 1f);
    }
}
