using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nakha : MonoBehaviour
{
    public GameObject[] nakhaers;
    public Transform[] nakhaTransform;

    int indexer;

    void Start()
    {
        StartCoroutine(NakhaDntntn());
    }

    Vector3 RandomTransform()
    {
        Transform t = nakhaTransform[Random.Range(0, nakhaTransform.Length)];

        return new Vector3(t.position.x, t.position.y, t.position.z);
    }

    YieldInstruction delay = new WaitForSeconds(0.5f);

    IEnumerator NakhaDntntn()
    {
        yield return delay;

        for (int i = 0; i < nakhaers.Length - 1; i++)
        {
            nakhaers[i].SetActive(true);
            nakhaers[i].transform.position = RandomTransform();
            nakhaers[i].transform.rotation = Random.rotation;
            yield return delay;
        }

        nakhaers[5].SetActive(true);
    }
}