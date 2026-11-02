using UnityEditor;
using UnityEngine;

public class fruitscript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float gravity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed += gravity * Time.deltaTime;

        transform.position += Vector3.down * speed;
    }
}
