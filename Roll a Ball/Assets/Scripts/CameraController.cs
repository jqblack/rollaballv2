using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    //Referencia a nuestro jugador
    public GameObject jugador;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - jugador.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Se ejecuta cada frame, pero después de haber procesado todo. Es más
    //exacto para la cámara

    void LateUpdate()
    {
        //Actualizo la posición de la cámara
        transform.position = jugador.transform.position + offset;
    }


}
