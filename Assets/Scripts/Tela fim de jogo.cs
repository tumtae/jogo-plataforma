using UnityEngine;
using TMPro;

public class Telafimdejogo : MonoBehaviour
{
    public TextMeshProUGUI texto;
    
    void Start(){
        texto.text = "Você pegou a super estrela\nfim do jogo!!!";
        texto.enabled = false;
    }
    
    public void MostrarTexto(){
        texto.enabled = true;
    }
}
