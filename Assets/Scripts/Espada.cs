using UnityEngine;

public class Espada : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Inimigo"))
        {
            Destroy(other.gameObject);
        }
    }
}
