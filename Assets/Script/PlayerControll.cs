using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audioDeath;
    void OnCollisionEnter2D(Collision2D collision)
    {
        audioDeath.Play();
        gameManager.Death();
    }
}
