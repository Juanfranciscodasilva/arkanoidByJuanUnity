using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladrillo : MonoBehaviour
{
    public SpriteRenderer ladrillo;
    private int golpesRestantes;
    private void Start()
    {
        ladrillo = GetComponent<SpriteRenderer>();
        if (gameObject.CompareTag("LadrilloGolpes1"))
        {
            golpesRestantes = 1;
        }
        else if (gameObject.CompareTag("LadrilloGolpes2"))
        {
            golpesRestantes = 2;
        }
        else if (gameObject.CompareTag("LadrilloGolpes3"))
        {
            golpesRestantes = 3;
        }
        else if (gameObject.CompareTag("LadrilloGolpes4"))
        {
            golpesRestantes = 4;
        }
    }

    private void Update()
    {
        if (golpesRestantes == 4)
        {
            ladrillo.color = Color.magenta;
        }
        else if (golpesRestantes == 3)
        {
            ladrillo.color = Color.red;
        }
        else if (golpesRestantes == 2)
        {
            ladrillo.color = new Color(0.9f,0.5f,0,1);
        }
        else if (golpesRestantes == 1)
        {
            ladrillo.color = Color.yellow;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            if (golpesRestantes <= 1)
            {
                FindObjectOfType<GameManager>().MirarSiHaTerminadoElNivel();
                Destroy(gameObject);
            }
            else
            {
                golpesRestantes--;
            }
        }
    }
}
