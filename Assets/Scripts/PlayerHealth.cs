using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 1;


    private void Start()
    {
       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DamagePlayer(1);
        }
    }

    public void DamagePlayer(int damage)
    {
        lives -= damage;
        Debug.Log("Player lives: " + lives);

  

        if (lives <= 0)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.RestartGame();
            }
            else
            {
                Debug.LogError("GameManager.Instance is NULL");
            }
        }
    }

    
}
