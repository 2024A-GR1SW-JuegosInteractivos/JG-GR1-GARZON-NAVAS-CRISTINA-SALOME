using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public GameObject player;  // El objeto del jugador
    public GameObject victoryMessagePanel;  // El panel para el mensaje de victoria
    public Text victoryMessageText;  // El texto donde se mostrará el mensaje

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Desactivar al jugador para simular que desaparece
            player.SetActive(false);

            // Mostrar el mensaje de victoria
            victoryMessagePanel.SetActive(true);
            victoryMessageText.text = "¡Felicidades, lograste superar el reto matemático !!";
        }
    }
}