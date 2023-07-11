using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSprite : MonoBehaviour
{
    public float velocidad = 5f; 

    private void Update()
    {
        float movimientoVertical = Input.GetAxis("Vertical"); 

        
        Vector3 direccionMovimiento = new Vector3(1f, movimientoVertical, 0f);

        
        Vector3 desplazamiento = direccionMovimiento * velocidad * Time.deltaTime;

        
        transform.Translate(desplazamiento);
    }
}

