using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SteamVR_TrackedObject))]

public class getControllerVelocity : MonoBehaviour {

    //reference to the tracked-object component on the controller/HMD GameObject
    SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;
    public Vector3 velocity;

    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        device = SteamVR_Controller.Input((int)trackedObj.index);
        velocity = device.velocity;
    }
}
