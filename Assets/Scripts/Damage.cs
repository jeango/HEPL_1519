using System.Linq;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public string[] tagsToIgnore;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!tagsToIgnore.Contains(other.attachedRigidbody.tag))
        {
            Destroy(other.attachedRigidbody.gameObject);
        }
    }
    
}