using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarSiguienteNivel : MonoBehaviour
{
    public string nombreSiguienteNivel; // Nombre de la escena del siguiente nivel

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verifica si el objeto que colisionó tiene la etiqueta "Player"
        {
            SceneManager.LoadScene(nombreSiguienteNivel); // Carga la escena del siguiente nivel
        }
    }
}
