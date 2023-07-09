using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Verifica si el objeto que colisionó tiene la etiqueta "Player"
        {
            Destroy(gameObject); // Destruye el objeto actual (el que tiene este script adjunto)
        }
    }
}
