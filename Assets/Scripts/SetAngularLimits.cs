using UnityEngine;
using System.Collections;

public class SetAngularLimits : MonoBehaviour {

	public ConfigurableJoint configurableJoint; // there should only be one configurable joint for this script

	public KeyCode keyAngularXMotionState = KeyCode.Q;
	public KeyCode keyAngularYMotionState = KeyCode.W;
	public KeyCode keyAngularZMotionState = KeyCode.E;
	private int press1Count=0;
	private int press2Count=0;
	private int press3Count=0;
	// Use this for initialization
	void Start () {
		press1Count=0;
		press2Count=0;
		press3Count=0;



	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(keyAngularXMotionState)) {

			//Debug.Log("Switch AngularXMotion");

			press1Count++;

			if (press1Count == 1 ) {

				Debug.Log("AngularXMotion is Free");
				configurableJoint.angularXMotion = ConfigurableJointMotion.Free;

			}
			if (press1Count == 2 ) {
				
				Debug.Log("AngularXMotion is Limited");
				configurableJoint.angularXMotion  = ConfigurableJointMotion.Limited;
			}
			if (press1Count == 3 ) {
				
				Debug.Log("AngularXMotion is Locked");
				press1Count =0;
				configurableJoint.angularXMotion  = ConfigurableJointMotion.Locked;
			}


		}
		if (Input.GetKeyDown(keyAngularYMotionState)) {
			
			press2Count++;
			
			if (press2Count == 1 ) {
				
				Debug.Log("AngularYMotion is Free");
				configurableJoint.angularYMotion = ConfigurableJointMotion.Free;
				
			}
			if (press2Count == 2 ) {
				
				Debug.Log("AngularYMotion is Limited");
				configurableJoint.angularYMotion  = ConfigurableJointMotion.Limited;
			}
			if (press2Count == 3 ) {
				
				Debug.Log("AngularYMotion is Locked");
				press2Count =0;
				configurableJoint.angularYMotion  = ConfigurableJointMotion.Locked;
			}
		}
		if (Input.GetKeyDown(keyAngularZMotionState)) {
			
			press3Count++;
			
			if (press3Count == 1 ) {
				
				Debug.Log("AngularZMotion is Free");
				configurableJoint.angularZMotion = ConfigurableJointMotion.Free;
				
			}
			if (press3Count == 2 ) {
				
				Debug.Log("AngularZMotion is Limited");
				configurableJoint.angularZMotion  = ConfigurableJointMotion.Limited;
			}
			if (press3Count == 3 ) {
				
				Debug.Log("AngularZMotion is Locked");
				press3Count =0;
				configurableJoint.angularZMotion  = ConfigurableJointMotion.Locked;
			}
		}

	}
}
