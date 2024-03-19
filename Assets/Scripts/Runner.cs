using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Runner : MonoBehaviour
{
    bool run;

    public Transform goal;
    public Rigidbody body;
    public Animator animator;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            Vector3 moveDirection = (goal.position - transform.position).normalized;
            body.MovePosition(transform.position + moveDirection * 0.5f);
            transform.LookAt(goal);

            if(Vector3.Distance(transform.position, goal.position) <= 0.1)
                gameObject.SetActive(false);
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }

    public void RunerSetting(Transform goal)
    {
        this.goal = goal;

        /*
        int rand = Random.Range(0, 4);

        if(rand == 0)
            animator.SetBool("Run1", true);
        else if(rand == 1)
            animator.SetBool("Run2", true);
        else if(rand == 2)
            animator.SetBool("Run3", true);
        else
            animator.SetBool("Run4", true);
        */

        run = true;
    }
}
