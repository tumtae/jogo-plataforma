using UnityEngine;
using System.Collections;

public class Botao : MonoBehaviour
{
    public GameObject parede;
    public GameObject botao;
    Vector3 posição_inicial;
    Vector3 posição_inicial_parede;
    public Vector3 alvoBotao;
    public Transform alvoParede;

    public float speed = 5f;

    bool ativado = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger ativado");
        if (other.CompareTag("Player"))
        {
            ativado = true;
        }
    }

    void Start()
    {
        posição_inicial = transform.position;
        posição_inicial_parede = parede.transform.position;
    }

    void Update()
    {
        if (ativado)
        {
            parede.transform.position = Vector3.MoveTowards(
                parede.transform.position,
                alvoParede.position,
                speed * Time.deltaTime
            );

            botao.transform.position = Vector3.MoveTowards(
                botao.transform.position,
                alvoBotao,
                speed * Time.deltaTime
            );
        StartCoroutine(timer_botão());
        
        
        
        }
    }


    IEnumerator timer_botão()
    {
        if(ativado == true){
        yield return new WaitForSeconds(2f);
        botao.transform.position = Vector3.MoveTowards(
            botao.transform.position,
            posição_inicial,
            speed * Time.deltaTime
        );
        parede.transform.position = Vector3.MoveTowards(
            parede.transform.position,
            posição_inicial_parede,
            speed * Time.deltaTime
        );
        ativado = false;
    }
}
}