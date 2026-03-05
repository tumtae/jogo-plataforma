using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.Getkey("d")){
        this.transform.Translate(0,0,0.05f);
     } 

    Physics.CheckSphere(transform.position, 1f);
    }
}
