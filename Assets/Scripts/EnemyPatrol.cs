using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentPoint;
    public float speed;
    public float distancia;
    public bool patrullando =true;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
        
       // anim.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (patrullando == true)
        {     
        Vector2 point = currentPoint.position - transform.position;
        if(currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
            
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        

        distancia = Vector2.Distance(transform.position, currentPoint.position);
        

        if (distancia < 1f && currentPoint == pointB.transform)
        {
            
            flip();

            currentPoint = pointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 1f && currentPoint == pointA.transform)
        {
            flip();
            currentPoint = pointB.transform;
        }
        }

        else
        {
            rb.velocity = new Vector2(0, 0);
        }

    }
    private void flip ()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointB.transform.position, 0.5f);
        Gizmos.DrawLine(pointA.transform.position, pointB.transform.position);

    }
}
