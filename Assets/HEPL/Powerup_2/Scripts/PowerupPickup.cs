using UnityEngine;

public class PowerupPickup : MonoBehaviour
{
    public Powerup powerup;

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        if (!powerup) return;
        var obj = other.attachedRigidbody?.gameObject ?? other.gameObject;
        var buff = Instantiate(powerup, obj.transform.position, obj.transform.rotation);
        buff.transform.parent = obj.transform;
        buff.Activate();
    }
}