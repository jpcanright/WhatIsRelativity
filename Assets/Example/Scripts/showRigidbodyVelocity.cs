using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showRigidbodyVelocity : MonoBehaviour {

    public double rigidBodyVelocity;
    public Vector3 rigidBodyVelocityVector;
    
	
	// Update is called once per frame
	void Update () {
        rigidBodyVelocityVector = gameObject.GetComponent<Rigidbody>().velocity;
        rigidBodyVelocity = rigidBodyVelocityVector.magnitude;
	}
}
