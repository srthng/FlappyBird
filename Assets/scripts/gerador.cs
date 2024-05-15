using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 3;
    private float cronometro;

    [SerializeField]
    private GameObject ModeloObstaculo;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
           
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;

        if(this.cronometro > 0)
        {
            GameObject.Instantiate(this.ModeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}
