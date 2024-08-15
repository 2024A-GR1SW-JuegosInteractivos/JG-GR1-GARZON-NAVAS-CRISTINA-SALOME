using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Referencia al transform del jugador
    public Vector3 offset;    // Desplazamiento de la cámara respecto al jugador

    void Update()
    {
        // Actualiza la posición de la cámara para que siga al jugador
        transform.position = player.position + offset;
    }
}