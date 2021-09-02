using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour

{
    [SerializeField]
    private GameObject[] descontos;
    [SerializeField]
    private GameObject prejuizo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DescontosSpawnRoutine());
        StartCoroutine(PrejuizoSpawnRoutine());
    }

    IEnumerator DescontosSpawnRoutine()
    {
        while (true)
        {
            int randomDescontos = Random.Range(0, 4);
            Instantiate(descontos[randomDescontos], new Vector3(Random.Range(7f, -7f), 5.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }

    IEnumerator PrejuizoSpawnRoutine()
    {
        while (true)
        {
            Instantiate(prejuizo, new Vector3(Random.Range(7f, -7f), 5.0f, 0), Quaternion.identity);
            yield return new WaitForSeconds(4.0f);
        }
    }
}
