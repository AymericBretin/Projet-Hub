using UnityEngine;

public class EnnemiWaypoint : MonoBehaviour
{
    public float speed = 10;
    public Transform[] waypoint;

    public WeakSpot weakSpot;
    public SpriteRenderer graph;
    private Transform target;
    private int dest = 0;

    void Start()
    {
        target = waypoint[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (weakSpot.count == 0)
        {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

            if (Vector3.Distance(transform.position, target.position) < 0.3f)
            {
                dest = (dest + 1) % waypoint.Length;
                target = waypoint[dest];
                graph.flipX = !graph.flipX;
            }
        }
    }
}
