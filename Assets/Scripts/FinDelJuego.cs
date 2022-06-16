using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDelJuego : MonoBehaviour
{

    public void GuardarPuntuacionYReiniciar()
    {
        //TODO guardar puntuacion con firebase
        ReiniciarJuego();

    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
