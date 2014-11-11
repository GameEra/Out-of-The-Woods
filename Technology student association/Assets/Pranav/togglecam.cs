using UnityEngine;
using System.Collections;

public class togglecam : MonoBehaviour {

	bool isSecondary;
	public GameObject mainCamera;
	public GameObject secondaryCamera;

	void Start() {

		isSecondary = false;

	}

	void Update () {

		if(Input.GetKeyDown ("p"))
		{
			isSecondary = !isSecondary;
		}



		if(isSecondary == false)
		{
			secondaryCamera.camera.active = false;
			mainCamera.camera.active = true;
		}else
		{
			secondaryCamera.camera.active = true;
			mainCamera.camera.active = false;
		}

	}

}