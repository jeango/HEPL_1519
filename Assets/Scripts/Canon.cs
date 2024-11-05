using UnityEngine;
using UnityEngine.InputSystem;

public class Canon : MonoBehaviour
{
    public GameObject projectile;


    public void Fire(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }
}
