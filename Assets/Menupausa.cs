using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menupausa : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject botonpausa;

    [SerializeField] private GameObject menupausa;
    public void pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
        
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void cerrar()
    {
        Debug.Log("cerrando juego");
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
