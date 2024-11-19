using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float timeToDestroy;

    private void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
}
