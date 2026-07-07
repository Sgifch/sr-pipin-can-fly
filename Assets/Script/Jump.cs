using JetBrains.Annotations;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float timer;
    private float time = 0;
    private bool onClick = true;
    private Rigidbody2D rb;
    private Animator anim;
    private AudioSource audio;

    private void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
        anim = player.GetComponent<Animator>();
        audio = player.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!onClick)
        {
            if (time >= timer)
            {
                time = 0;
                onClick = true;
            }
            else
            {
                time+=Time.deltaTime;
            }
        }
    }
    public void ClickToJump()
    {
        if (onClick)
        {
            rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            audio.Play();
            anim.SetTrigger("jump");
            onClick = false;   
        }
    }
}
