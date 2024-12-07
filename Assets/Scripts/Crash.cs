using UnityEngine;

public class Crash : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ImpactCapacity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocity = rb.linearVelocity;
        Debug.Log("Velocity: " + velocity.magnitude);
        if (velocity.magnitude > ImpactCapacity)
        {
            Debug.Log("Crash!");
        }
    }
}
