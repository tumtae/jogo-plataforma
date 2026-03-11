using UnityEngine;

public class Botao : MonoBehaviour
{
    public GameObject parede;
    public GameObject botao;

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
        }
    }
}