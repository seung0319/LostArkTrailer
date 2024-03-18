using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardVsLizard : MonoBehaviour
{
    public Animator lizard1;
    public Animator lizard2;

    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        Lizard1Action();
        Invoke("Lizard2Action", delay);
    }

    void Lizard1Action()
    {
        lizard1.SetTrigger("attck");
    }

    void Lizard2Action()
    {
        lizard2.SetTrigger("hit");
    }
}
