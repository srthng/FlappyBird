using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f, 1f)]
    [SerializeField]
    private float velocidade = 3;

    private float mx;
    private float my;
    private Vector2 mousePos;

    Rigidbody2D rb;

    private void Awake()
    {

        this.rb = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            this.Impulsionar();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }


    private void Impulsionar()
    {
        this.rb.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }
}
