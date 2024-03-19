using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroWalk : MonoBehaviour
{
    public Rigidbody body;
    public Animator animator;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        t += Time.deltaTime;
        if(t > 4)
        {
            animator.SetBool("stop", true);
            if (t > 8)
                animator.SetBool("fight", true);
        }
        else
        {
            body.velocity = transform.forward * 2f;
        }
    }
}
