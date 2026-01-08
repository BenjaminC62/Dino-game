using UnityEngine;

public class Cactus : MonoBehaviour
{
    public float speed = 6f;
    public float destroyX = -10f;
    public float spawnX = 10f;
    public GameObject cactusPrefab;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Instantiate(cactusPrefab, new Vector3(spawnX, transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}