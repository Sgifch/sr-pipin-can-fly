using UnityEngine;

public class AddScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().AddScore();
        }
    }
}
