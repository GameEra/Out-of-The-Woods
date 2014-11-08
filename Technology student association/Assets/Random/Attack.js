#pragma strict


//Test

function Start () {

}

function Update () {

	if(Input.GetButtonDown("Fire1"))
	{
		animation.Play("Hit");
	}

}