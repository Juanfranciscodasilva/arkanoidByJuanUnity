using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarPartida()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void VerRanking()
    {

    }
}
