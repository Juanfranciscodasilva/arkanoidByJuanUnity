using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlMarcador : MonoBehaviour
{
    public int vidas = 3;
    public long puntos = 0;
    public int toquesAntesDeBarra = 0;
    public Text textoPuntuacion;
    public Text textoVidas;
    private const int PUNTO_POR_TOQUE = 10;

    void Start()
    {
        textoPuntuacion = GameObject.Find("Puntuacion").GetComponent<Text>();
        textoVidas = GameObject.Find("Vidas").GetComponent<Text>();
        ActualizarTextoPuntuacion();
        ActualizarTextoVidas();
    }

    public void PerderVida()
    {
        if (vidas <= 0)
        {
            SceneManager.LoadScene("FinDelJuego");
        }
        else
        {
            vidas--;
            ReiniciarNivel();
        }
    }

    public void ActualizarTextoPuntuacion()
    {
        textoPuntuacion.text = "Puntuación: " + puntos.ToString();
    }

    public void ActualizarTextoVidas()
    {
        textoVidas.text = "Vidas: " + vidas.ToString();
    }

    public void ReiniciarNivel()
    {
        FindObjectOfType<Bola>().ReiniciarBola();
        FindObjectOfType<BarraPrincipal>().ReiniciarBarraPrincipal();
    }

    public void SumarToqueALadrillo()
    {
        toquesAntesDeBarra++;
        puntos += (toquesAntesDeBarra * PUNTO_POR_TOQUE);

    }
}
