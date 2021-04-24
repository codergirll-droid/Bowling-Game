using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Rigidbody bullet;
    [SerializeField] float power = 1500f;
    [SerializeField] float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(h, v, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            instance.AddForce(fwd * power);
            Destroy(instance.gameObject, 8f);
        }

    }
}
