using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarOn : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;

    public void StarOnH()
    {
        star1.SetActive(true);
        star2.SetActive(true);
    }
}
