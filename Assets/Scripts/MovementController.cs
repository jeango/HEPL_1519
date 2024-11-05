using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour
{
	public int Speed;
	public Vector2 Direction;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

	void Move()
	{
		var currentPosition = transform.position;
		var velocity = Direction.normalized * Speed * Time.deltaTime;
		transform.position = currentPosition + (Vector3)velocity;
	}

	public void SetDirection(InputAction.CallbackContext context)
	{
		Direction = context.ReadValue<Vector2>();
	}

}
