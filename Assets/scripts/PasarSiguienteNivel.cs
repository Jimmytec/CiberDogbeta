using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarSiguienteNivel : MonoBehaviour
{
    public string nombreSiguienteNivel; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            SceneManager.LoadScene(nombreSiguienteNivel); 
        }
    }
}
