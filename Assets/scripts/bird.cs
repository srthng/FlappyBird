using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;

    Rigidbody2D fisica;

    // Start is called before the first frame update
    void Start()
    {
        this.fisica = GetComponent<Rigidbody2D>(); 
    }

    void impulsionar(){
        this.fisica.AddForce(Vector2.up * velocidade,ForceMode2D.Impulse);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            this.impulsionar();
        }
    }
}
