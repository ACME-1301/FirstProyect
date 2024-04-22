using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public int forceConst = 10;

    private bool canJump;
    private Rigidbody selfRigidbody;

    private void Start()
    {
        selfRigidbody = GetComponent <Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
                selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }
    }
    private void Update ()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            canJump = true;
        }
    }
}
