using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject post;
    public float speed;
    public float shift;
    public float interval;
    private float time = 0;

    void Update()
    {
        if (time >= interval)
        {
            SpawnPost();
            time = 0;
        }
        else
        {
            time+=Time.deltaTime;
        }
    }

    public void SpawnPost()
    {
        float shiftY = Random.Range(-shift, shift);
        Vector3 newPosition = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y+shiftY, gameObject.transform.position.x);
        GameObject currentPost = Instantiate(post, newPosition, Quaternion.identity);
        currentPost.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-speed, 0);
    }
}
