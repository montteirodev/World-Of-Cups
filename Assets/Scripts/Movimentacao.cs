using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade = 5f;
    public float pulo = 3f;
    Rigidbody2D rb;
    bool podePular = true;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && podePular)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, pulo);
            podePular = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            podePular = true;
        }
    }
}

