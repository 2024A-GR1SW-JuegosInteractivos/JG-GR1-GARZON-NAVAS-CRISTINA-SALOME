using UnityEngine;

public class Monedas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Código para recolectar el tesoro
            Debug.Log("Money Collected!");
            Destroy(gameObject); // Elimina el tesoro de la escena al ser recolectado
        }
    }
}

