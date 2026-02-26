using UnityEngine;

public class Feitiso : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.right * velocidade, ForceMode2D.Impulse);

        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
