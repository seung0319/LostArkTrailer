using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    public Transform runergoal;
    public Transform walkgoal;

    public Runer[] runers;
    public Walker[] walker;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            RunOrder();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            WalkOrder();
        }
    }

    public void RunOrder()
    {
        foreach (Runer runner in runers)
        {
            runner.RunerSetting(runergoal);
        }
    }

    public void WalkOrder()
    {
        foreach (Walker walker in walker)
        {
            walker.WalkSetting(walkgoal);
        }
    }
}
