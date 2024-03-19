using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagersWalk : MonoBehaviour
{
    public Rigidbody body;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        int rand = Random.Range(0, 4);
        if (rand == 0)
            animator.SetBool("walk1", true);
        else if (rand == 1)
            animator.SetBool("walk2", true);
        else if (rand == 2)
            animator.SetBool("walk3", true);
        else
            animator.SetBool("walk4", true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        body.velocity = transform.forward * 2f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.name.Contains("Terrain"))
            Destroy(gameObject);
    }
}
