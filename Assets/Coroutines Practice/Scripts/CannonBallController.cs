using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallController : MonoBehaviour
{
    private Rigidbody cannonBallRb;
    public float moveForce = 1.5f;
    private float destroyAfterSeconds = 3;
    // Start is called before the first frame update
    void Start()
    {
       cannonBallRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        cannonBallRb.AddForce(Vector3.forward * moveForce, ForceMode.Impulse);
        Destroy(gameObject, destroyAfterSeconds);
    }
}
