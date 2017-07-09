using UnityEngine;
using System.Collections;

public class SetRotationAxesConstraints : MonoBehaviour {
	
	public Rigidbody rigidbody; // there should only be one configurable joint for this script
	
	public KeyCode keyXRotationConstraint = KeyCode.Alpha1;
	public KeyCode keyYRotationConstraint = KeyCode.Alpha2;
	public KeyCode keyZRotationConstraint = KeyCode.Alpha3;
	public KeyCode keyResetRotationConstraint = KeyCode.Alpha4;

	private RigidbodyConstraints originalConstraints;

	private int pressCount1;
	private int pressCount2;
	private int pressCount3;

	// Use this for initialization
	void Start () {
		pressCount1 = 0;
		pressCount2 = 0;
		pressCount3 = 0;
		originalConstraints = rigidbody.constraints;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(keyXRotationConstraint)) {

			rigidbody.constraints |= RigidbodyConstraints.FreezeRotationX;

			 if (pressCount1 == 0) {
				originalConstraints = rigidbody.constraints;
				//rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationX;
				pressCount1++;
			} else {

				//rigidbody.constraints = originalConstraints;

				rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationX;


				pressCount1 = 0;
				//rigidbody.constraints = RigidbodyConstraints.FreezeRotationX;


			}

		}
		if (Input.GetKeyDown(keyYRotationConstraint)) {

			//rigidbody.constraints |= RigidbodyConstraints.FreezeRotationY;

			if (pressCount2 == 0) {
				originalConstraints = rigidbody.constraints;
				//rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationY;
				pressCount2++;
			} else {
				//rigidbody.constraints = originalConstraints;
				
				rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationY;
				
				
				pressCount2 = 0;
			}

		}
		if (Input.GetKeyDown(keyZRotationConstraint)) {
			//rigidbody.constraints |= RigidbodyConstraints.FreezeRotationZ;

			if (pressCount3 == 0) {
				originalConstraints = rigidbody.constraints;
				//rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationZ;
				pressCount3++;
			} else {
				//rigidbody.constraints = originalConstraints;
				
				rigidbody.constraints = RigidbodyConstraints.None;
				rigidbody.constraints |= RigidbodyConstraints.FreezeRotationZ;
				
				
				pressCount3 = 0;
			}

		}
		if (Input.GetKeyDown(keyResetRotationConstraint)) {
			rigidbody.constraints = RigidbodyConstraints.None;
		}
		
	}
}
