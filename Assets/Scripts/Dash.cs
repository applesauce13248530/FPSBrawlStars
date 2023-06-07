using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    public float dashSpeed;
    Rigidbody rig;
    bool isDashing;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Dashing()
    {
        rig.AddForce(transform.forward * dashSpeed, ForceMode.Impulse);
        isDashing = false;
    }
}
