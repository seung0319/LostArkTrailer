using UnityEngine;

public class Runner : MonoBehaviour
{
    bool run;

    public Transform goal;
    public Rigidbody body;
    public Animator animator;

    public Vector3 q;

    public bool r;

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
            body.MovePosition(transform.position + moveDirection * 0.2f);
            transform.LookAt(goal);

            if (Vector3.Distance(transform.position, goal.position) <= 3)
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

        


        //int rand = Random.Range(0, 4);

        //if (rand == 0)
        //    animator.SetBool("ZomebieRun", true);
        //else if (rand == 1)
        //    animator.SetBool("TurnRun", true);
        //else if (rand == 2)
        //    animator.SetBool("BehindRun", true);
        //else
        //    animator.SetBool("JustRun", true);


        run = true;
        if (r)
        {
            return;
        }
        animator.SetBool("run", true);
    }
}
