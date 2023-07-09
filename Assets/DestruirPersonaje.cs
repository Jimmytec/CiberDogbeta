using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruirPersonaje : MonoBehaviour
{
    public string nombreEscena; // Nombre de la escena actual para reiniciar

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verifica si el objeto que colisionó tiene la etiqueta "Player"
        {
            SceneManager.LoadScene(nombreEscena); // Reinicia la escena actual
        }
    }
}
