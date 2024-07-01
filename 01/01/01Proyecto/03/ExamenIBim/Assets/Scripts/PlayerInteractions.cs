using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractions : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private SpriteRenderer spriteRenderer;
    Color comioChocolate = new Color(255, 0, 0, 255);
    float delayDestroy = 0.5f;
    private AudioSource audioSource;

    // Guarda los valores originales
    private float originalMoveSpeed;
    private Color originalColor;

    // Clip de sonido para el chocolate
    public AudioClip chocolateSound;

    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();

        // Verificar si los componentes están asignados correctamente
        if (playerMovement == null)
        {
            Debug.LogError("PlayerMovement component is missing!");
        }

        if (spriteRenderer == null)
        {
            Debug.LogError("SpriteRenderer component is missing!");
        }

        if (audioSource == null)
        {
            Debug.LogError("AudioSource component is missing!");
        }

        // Guarda los valores originales
        if (playerMovement != null)
        {
            originalMoveSpeed = playerMovement.moveSpeed;
        }

        if (spriteRenderer != null)
        {
            originalColor = spriteRenderer.color;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bone"))
        {
            // Restablece la velocidad y el color original
            if (playerMovement != null)
            {
                playerMovement.moveSpeed = originalMoveSpeed;
            }

            if (spriteRenderer != null)
            {
                spriteRenderer.color = originalColor;
            }

            Destroy(collision.gameObject, delayDestroy);
        }
        else if (collision.CompareTag("Chocolate"))
        {
            Debug.Log("Comio Chocolate");
            if (playerMovement != null)
            {
                playerMovement.moveSpeed = 0.9f;
            }

            if (spriteRenderer != null)
            {
                spriteRenderer.color = comioChocolate;
            }

            Destroy(collision.gameObject, delayDestroy);

            if (chocolateSound != null && audioSource != null)
            {
                Debug.Log("Reproduciendo sonido del chocolate");
                audioSource.PlayOneShot(chocolateSound);
            }
            else
            {
                Debug.LogWarning("Chocolate sound clip is not assigned or AudioSource is missing!");
            }
        }
        else if (collision.CompareTag("Death"))
        {
            // Reinicia el juego cargando la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (collision.CompareTag("Persona"))
        {
            Debug.Log("Juego finalizado");
            // Opcional: puedes agregar más lógica aquí para finalizar el juego
        }
    }
}
