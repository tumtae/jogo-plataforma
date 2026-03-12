using UnityEngine;
using System.Collections;

public class Pedracaindo : MonoBehaviour
{
    public float forçaQueda = 5f;
    public float velocidadesubida = 2f;
    public Vector3 posição_inicial;
    public Transform alvo;
    bool caiu = false;
    public float tempoespera = 1f;
    public float tempocooldown = 2f;
    private bool cooldown = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        posição_inicial = transform.position;
        StartCoroutine(cooldowninicial());
    
    }


    IEnumerator cooldowninicial()
    {
        yield return new WaitForSeconds(tempocooldown);
        cooldown = false;
    }

    // Update is called once per frame
    void Update()
    {if(cooldown == false){
        if(caiu == false){
            StartCoroutine(Queda());
        }

        if(caiu == true){
            Subida();
        }
    }
    }

    IEnumerator Queda()
    {
        
        yield return new WaitForSeconds(tempoespera);
        transform.position = Vector3.MoveTowards(
            transform.position,
            alvo.position,
            forçaQueda * Time.deltaTime
                
        );
        if(transform.position == alvo.position){
            caiu = true;
        }
       
    }

    void Subida()
    {
        
        if(caiu == true){
            transform.position = Vector3.MoveTowards(
                transform.position,
                posição_inicial,
                velocidadesubida * Time.deltaTime
            );
            if(transform.position == posição_inicial)
            {
                caiu = false;
            }
        }
    }
}
