using UnityEngine;
using System.Collections;

public class Ataque : MonoBehaviour
{
    public GameObject espada;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine(Atacar());
        }
    }

    IEnumerator Atacar()
    {
        espada.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        espada.SetActive(false);
    }
}
