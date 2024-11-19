using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToIgnore;
    public bool canKill;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        var body = other.attachedRigidbody;
        if (!body) return;
        if (!tagsToIgnore.Contains(body.tag))
        {
            var deathCtrl = body.GetComponent<DeathController>();
            if (canKill && deathCtrl)
            {
                deathCtrl.Kill();
            }
            else
            {
                Destroy(other.attachedRigidbody.gameObject);
            }
        }
    }
    
}
