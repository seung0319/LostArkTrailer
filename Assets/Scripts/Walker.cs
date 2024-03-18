using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    public Transform goal;
    public Rigidbody body;
    public Animator animator;

    bool walk;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (walk)
        {
            Vector3 moveDirection = (goal.position - transform.position).normalized;
            body.MovePosition(transform.position + moveDirection * 0.2f);
            transform.LookAt(goal);

            if (Vector3.Distance(transform.position, goal.position) <= 0.1)
                gameObject.SetActive(false);
        }
    }

    public void WalkSetting(Transform goal)
    {
        this.goal = goal;
        animator.SetBool("run", true);
        walk = true;
    }
}
