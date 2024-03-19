using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    public Transform runergoal;
    public Transform walkgoal;

    public Runner[] runners;
    public Walker[] walkers;

    public float speed;

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
        foreach (Runner runner in runners)
        {
            runner.RunerSetting(runergoal, speed);
        }
    }

    public void WalkOrder()
    {
        foreach (Walker walker in walkers)
        {
            walker.WalkSetting(walkgoal);
        }
    }
}
