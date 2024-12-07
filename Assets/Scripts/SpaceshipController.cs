using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceshipController : MonoBehaviour
{
    //private bool HitFloor = false;
    [Tooltip("Thrust strength")]
    [SerializeField] float ThrustStrength = 1f;
    [Tooltip("Left and Right Torque strength")]
    [SerializeField] float TorqueStrength = 1f;


    [SerializeField]
    InputAction move = new InputAction(type: InputActionType.Value, expectedControlType: nameof(Vector2));

    private Rigidbody2D rb;

    void OnEnable()
    {
        move.Enable();
    }

    void OnDisable()
    {
        move.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up * ThrustStrength * move.ReadValue<Vector2>().y);
        rb.AddTorque(TorqueStrength * -move.ReadValue<Vector2>().x); // Around Z axis unless specified athorwise
    }
}
