using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f, 1f)]
    [SerializeField] private float fireRate = 0.5f;
    [SerializeField]
    private float velocidade = 3;

    private float mx;
    private float my;
    private Vector2 mousePos;

    Rigidbody2D fisica;

    private void Awake()
    {

        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("a");
            this.Impulsionar();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }


    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);
    }
}
