using UnityEngine;
using System.Collections;

public class Fall2Far : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.y < -10)
		{
			Application.LoadLevel("Forest.unity");
		}
	}

		
	}
