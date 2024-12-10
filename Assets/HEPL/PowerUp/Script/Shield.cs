using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shield : MonoBehaviour
{
    public AudioClip destroySound;
    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(destroySound, transform.position);
    }
}
