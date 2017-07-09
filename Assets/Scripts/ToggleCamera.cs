using UnityEngine;
using System.Collections;


public class ToggleCamera : MonoBehaviour {
	
	public Camera perspectiveCamera;
	public Camera orthographicCamera;
	public TouchTracker touchTracker;
	public KeyCode orthoPerspectiveCameraToggleKey = KeyCode.P;
	public KeyCode dofToggleKey = KeyCode.D;

	

	void Start () {
		perspectiveCamera.enabled = false; 
		orthographicCamera.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(orthoPerspectiveCameraToggleKey)) {

			perspectiveCamera.enabled = !perspectiveCamera.enabled;
			orthographicCamera.enabled = !orthographicCamera.enabled;

			if (perspectiveCamera.enabled) {
				if (touchTracker != null) {
					touchTracker.displayTouchPointsSwitch = false;
				}
			}
			if (orthographicCamera.enabled) {
				if (touchTracker != null) {
					touchTracker.displayTouchPointsSwitch = true;
				}
			}
		}
	
		if (Input.GetKeyDown(dofToggleKey)) {
			
			if (perspectiveCamera != null) {
				DepthOfFieldScatter dof = perspectiveCamera.gameObject.GetComponent<DepthOfFieldScatter>();
				dof.enabled = !dof.enabled;
				
			}
			
		}
			
	}

}
