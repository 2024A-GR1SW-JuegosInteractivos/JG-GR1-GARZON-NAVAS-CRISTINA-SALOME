using UnityEngine;
using UnityEngine.UI;

public class TreasureCollect : MonoBehaviour
{
    public GameObject messagePanel;  // Panel que contendrá el mensaje
    public Text messageText;  // Texto para mostrar las operaciones matemáticas

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Código para recolectar el tesoro
            Debug.Log("Treasure Collected!");
            ShowMessage();
            Destroy(gameObject); // Elimina el tesoro de la escena al ser recolectado
        }
    }

    void ShowMessage()
    {
        // Activar el panel del mensaje
        messagePanel.SetActive(true);

        // Configurar el mensaje de las operaciones matemáticas
        messageText.text = "Para poder ganar el nivel deberás descifrar el codigo y con ello encontaras una puerta que te ayudará a superar el reto\n" +
            "Para encontrar el código deberás resolver las siguientes operaciones matemáticas:\n" +
                           "Primer dígito: 12 + 21\n" +
                           "Segundo dígito: 9 x 8\n" +
                           "Tercer dígito: 12 / 4";
    }
}