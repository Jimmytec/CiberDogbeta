using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarJuego : MonoBehaviour
{
    public void Cerrar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Detiene la ejecuci�n del juego en el Editor de Unity
     #else
        Application.Quit(); // Cierra la aplicaci�n en un build final
     #endif
    }
}
