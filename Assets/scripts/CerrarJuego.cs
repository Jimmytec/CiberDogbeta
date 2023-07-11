using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarJuego : MonoBehaviour
{
    public void Cerrar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
     #else
        Application.Quit(); 
     #endif
    }
}
