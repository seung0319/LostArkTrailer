using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VilliagersRun : MonoBehaviour
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
            animator.SetBool("run1", true);
        else if (rand == 1)
            animator.SetBool("run2", true);
        else if (rand == 2)
            animator.SetBool("run3", true);
        else
            animator.SetBool("run4", true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        body.velocity = transform.forward * 3f;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.name.Contains("Terrain"))
            Destroy(gameObject);
    }
}
