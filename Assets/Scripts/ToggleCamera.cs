using UnityEngine;
using System.Collections;



public class ToggleCamera : MonoBehaviour {
	
	public Camera perspectiveCamera;
	public Camera orthographicCamera;
	public TouchTracker touchTracker;
	public KeyCode orthoPerspectiveCameraToggleKey = KeyCode.P;
	public KeyCode dofToggleKey = KeyCode.D;
	public KeyCode vignetteToggleKey = KeyCode.BackQuote;
	public KeyCode blurToggleKey = KeyCode.Backslash;

	

	void Start () {
		if (perspectiveCamera != null) {
		perspectiveCamera.enabled = false; 
		}

		orthographicCamera.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(orthoPerspectiveCameraToggleKey)) {

			if (perspectiveCamera != null) {
			
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

		if (Input.GetKeyDown(blurToggleKey)) {
			
			if (orthographicCamera.enabled) {
				Blur blo = orthographicCamera.gameObject.GetComponent<Blur>();
				blo.enabled = !blo.enabled;

			}

			if (perspectiveCamera != null) {
				if (perspectiveCamera.enabled) {
					Blur blp = perspectiveCamera.gameObject.GetComponent<Blur>();
					blp.enabled = !blp.enabled;
				
				}
			}
		}

		if (Input.GetKeyDown(vignetteToggleKey)) {
			
			if (orthographicCamera.enabled) {

				Vignetting vigo = orthographicCamera.gameObject.GetComponent<Vignetting>();
				vigo.enabled = !vigo.enabled;
			}
			if (perspectiveCamera != null) {
			if (perspectiveCamera.enabled) {
					Vignetting vigp = perspectiveCamera.gameObject.GetComponent<Vignetting>();
					vigp.enabled = !vigp.enabled;
				}
			}
		}
			
	}

}
