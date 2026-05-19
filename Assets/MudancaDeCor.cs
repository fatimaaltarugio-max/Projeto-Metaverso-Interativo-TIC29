using UnityEngine;
using UnityEngine.EventSystems;

public class MudancaDeCor1 : MonoBehaviour, IPointerDownHandler
{
    // Esta função força o Unity a aceitar o clique do mouse no PC mesmo com o Meta SDK ativo
    public void OnPointerDown(PointerEventData eventData)
    {
        Renderer renderizador = GetComponent<Renderer>();
        if (renderizador != null)
        {
            // Sorteia uma cor totalmente nova a cada clique
            renderizador.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}