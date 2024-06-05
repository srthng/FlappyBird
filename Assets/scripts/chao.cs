using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoDaImagemDaCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagemReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagemDaCena = tamanhoDaImagemReal * escala;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoDaImagemDaCena);
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }

    
}
