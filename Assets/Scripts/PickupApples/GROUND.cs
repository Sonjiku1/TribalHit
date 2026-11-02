using UnityEngine;

public class GROUND : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("fruit"))
        {
            collision.gameObject.transform.position = new Vector3(0, 4, 0);
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        }
    }
}
