using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nakha : MonoBehaviour
{
    public GameObject[] nakhaers;
    int indexer;

    void Start()
    {
        StartCoroutine(NakhaDntntn());
    }

    YieldInstruction delay = new WaitForSeconds(0.1f);

    IEnumerator NakhaDntntn()
    {
        while (nakhaers.Length != indexer)
        {
            nakhaers[indexer++].SetActive(true);
            yield return delay;
        }
    }
}
