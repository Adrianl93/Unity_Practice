using UnityEngine;

public class VictoryConditions : MonoBehaviour
{
    
    [SerializeField] private float timeToRestart = 1f;

    private void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            
                Debug.Log("¡Ganaste!");
              

                Invoke(nameof(RestartThroughManager), timeToRestart);
            
        }
    }

    private void RestartThroughManager()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.RestartGame();
        }
        else
        {
            Debug.LogError("GameManager.Instance es NULL");
        }
    }
}
