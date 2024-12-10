using UnityEngine;
using UnityEngine.InputSystem;

public class Movement_Controller : MonoBehaviour
{
    public int Speed;
    public Vector2 Direction;
    public Rigidbody2D body;

    // Update is called once per frame
    void Update()
    {
        if (!body || body.isKinematic)
        {
            Move();
        }
    }

    void FixedUpdate()
    {
        if (body && !body.isKinematic)
        {
            MoveDynamic();
        }
    }

    void MoveDynamic()
    {
        body.velocity = Direction.normalized * Speed;
    }
    void Move()
    {
        var currentPosition = transform.position;
        var velocity = Direction.normalized * Speed * Time.deltaTime;
        //currentPosition.x += Speed * Time.deltaTime;
        transform.position = currentPosition + (Vector3)velocity;
    }
    public void SetDirection(InputAction.CallbackContext context)
    {
        Direction = context.ReadValue<Vector2>();
    }
}
