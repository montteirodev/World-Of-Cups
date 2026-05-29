using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public float tempo = 5f;
    void Start()
    {
        Destroy(gameObject, tempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
