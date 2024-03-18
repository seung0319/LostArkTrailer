using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    public Transform goal;

    public Runer[] runers;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            RunOrder();
        }
    }

    public void RunOrder()
    {
        foreach (Runer runner in runers)
        {
            runner.RunerSetting(goal);
        }
    }
}
