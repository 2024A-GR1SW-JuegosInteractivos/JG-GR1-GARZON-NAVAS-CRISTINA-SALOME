using UnityEngine;
using UnityEngine.UI;

public class CodePuzzle : MonoBehaviour
{
    public GameObject door;  // La puerta que se activará
    public string correctCode = "33723";  // Código correcto para desbloquear la puerta
    public InputField codeInputField;  // Campo de entrada del código
    public Text feedbackText;  // Texto para retroalimentación

    private void Start()
    {
        // Inicializar estado
        if (door != null)
        {
            door.SetActive(false);  // Asegúrate de que la puerta esté inicialmente inactiva
        }
        feedbackText.text = "";  // Limpia el texto de retroalimentación
    }

    public void CheckCode()
    {
        string inputCode = codeInputField.text;  // Obtener el código ingresado

        if (inputCode == correctCode)
        {
            door.SetActive(true);  // Activa la puerta si el código es correcto
            feedbackText.text = "¡Código Correcto!";  // Mensaje de éxito
        }
        else
        {
            feedbackText.text = "Código Incorrecto. Intenta de nuevo.";  // Mensaje de error
        }
    }
}