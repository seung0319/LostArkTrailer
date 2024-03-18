using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LizardVsWolf : MonoBehaviour
{
    public Animator lizard1;
    public Animator wolf;

    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        lizard1.SetTrigger("attck");
        Invoke("WolfDie", delay);
    }

    void WolfDie()
    {
        wolf.SetTrigger("hit");
    }
}
