using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarJuego : MonoBehaviour
{
    public void Cerrar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detiene la ejecución del juego en el Editor de Unity
     #else
        Application.Quit(); // Cierra la aplicación en un build final
     #endif
    }
}
