using UnityEngine;
using System.Collections;

public class Hitmk1 : MonoBehaviour {

	public bool animation_bool;
	
	void Update()
	{
		
		if(animation_bool == true)
		{
			animation.Play("Hit.anim");
			
		}
		
		
		if(Input.GetButtonDown("r"))
		{
			animation_bool = true;
			
		}
		
		
		
	}
}