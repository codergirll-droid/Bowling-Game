using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] AudioClip hit;
    [SerializeField] AudioSource source;
    private void Start()
    {
        source.clip = hit;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("pin"))
        {
            source.Play();
        }
    }

}
