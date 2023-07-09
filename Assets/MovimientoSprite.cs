using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSprite : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del sprite

    private void Update()
    {
        float movimientoVertical = Input.GetAxis("Vertical"); // Obtiene el valor de entrada vertical (eje Y)

        // Calcula la dirección de movimiento
        Vector3 direccionMovimiento = new Vector3(1f, movimientoVertical, 0f);

        // Calcula el desplazamiento aplicando velocidad y el tiempo entre frames
        Vector3 desplazamiento = direccionMovimiento * velocidad * Time.deltaTime;

        // Actualiza la posición del sprite
        transform.Translate(desplazamiento);
    }
}

