using UnityEngine;
using System.Collections;

public class Inimigos : MonoBehaviour
{
    public GameObject Tutorial1;
    public GameObject Tutorial2;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        Tutorial1.SetActive(true);
        yield return new WaitForSeconds(3f);
        Tutorial1.SetActive(false);
        Tutorial2.SetActive(true);
    }
}




