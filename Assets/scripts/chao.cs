using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]       
    private float velocidade;

    private Vector3 posicaoinicial;
    private float tamanhoDaImagemNaCena;

    private void Awake()
    {
        this.posicaoinicial = this.transform.position;
        float tamanhoDaImagemReal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagemNaCena = tamanhoDaImagemReal * escala;
        
    }


    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoDaImagemNaCena);
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);

        this.transform.position = this.posicaoinicial + Vector3.left * deslocamento;

    }
}
