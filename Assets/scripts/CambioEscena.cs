using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public string ayuda; 

    public void CambiarEscena()
    {
        SceneManager.LoadScene(ayuda); 
    }
}
