using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraPrincipal : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    private float inputValue;

    public float velocidadMovimiento = 25;

    private Vector2 direccion;

    private Vector2 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void Update()
    {
        inputValue = Input.GetAxisRaw("Horizontal");

        if (inputValue == 1)
        {
            direccion = Vector2.right;
        }
        else if (inputValue == -1)
        {
            direccion = Vector2.left;
        }
        else
        {
            direccion = Vector2.zero;
        }

        rigidBody2D.AddForce(direccion*velocidadMovimiento*Time.deltaTime*100);
    }

    public void ReiniciarBarraPrincipal()
    {
        transform.position = posicionInicial;
        rigidBody2D.velocity = Vector2.zero;
    }
}
