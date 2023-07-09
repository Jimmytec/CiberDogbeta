using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string ayuda; // Nombre de la escena a la que quieres cambiar

    public void CambiarEscena()
    {
        SceneManager.LoadScene(ayuda); // Carga la escena con el nombre proporcionado
    }
}
