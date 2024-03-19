using UnityEditor.Rendering;
using UnityEngine;

public class Runner : MonoBehaviour
{
    bool run;

    private Transform goal;
    private Rigidbody body;
    private Animator animator;

    private Vector3 q;

    public bool r;

    private float speed;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();


        if (r)
        {
            return;
        }
        q = new Vector3(Random.Range(-360, 361), Quaternion.identity.y, Random.Range(-360, 361));
        transform.LookAt(q);
    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            Vector3 moveDirection = (goal.position - transform.position).normalized;
            body.MovePosition(transform.position + moveDirection * speed);
            transform.LookAt(goal);

            if (Vector3.Distance(transform.position, goal.position) <= 3)
                gameObject.SetActive(false);
        }
        else
        {
            body.velocity = Vector3.zero;
        }
    }

    public void RunerSetting(Transform goal, float speed)
    {
        this.goal = goal;
        this.speed = speed;

        run = true;
        if (r)
        {
            return;
        }
        animator.SetBool("run", true);
    }
}
