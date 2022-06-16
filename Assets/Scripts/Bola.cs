using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;

    public float speed = 250;

    private Vector2 velocidad;

    private Vector2 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;

        velocidad.x = Random.Range(-1f, 1f);

        velocidad.y = 1;

        rigidBody2D.AddForce(velocidad * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BarraPrincipal") && speed < 750)
        {
            speed += 2;
            ContactPoint2D puntoDeColision = collision.contacts[collision.contacts.Length-1];
            Vector2 barra = collision.gameObject.transform.position;
            float direccion = puntoDeColision.point.x - barra.x;
            rigidBody2D.velocity = Vector2.zero;
            rigidBody2D.AddForce(new Vector2(direccion, 1)*speed);
        }
        else if (collision.gameObject.CompareTag("BordeInferior"))
        {
            FindObjectOfType<ControlMarcador>().PerderVida();
        }
    }

    public void ReiniciarBola()
    {
        transform.position = posicionInicial;
        rigidBody2D.velocity = Vector2.zero;

        speed = 250;

        velocidad.x = Random.Range(-1f, 1f);

        velocidad.y = 1;

        rigidBody2D.AddForce(velocidad * speed);
    }
}
