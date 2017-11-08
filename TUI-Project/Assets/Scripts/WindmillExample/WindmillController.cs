using UnityEngine;
using System.Collections;

public class WindmillController : MonoBehaviour {

	//if this script is attached to the blades, this variable must be set to true
	public bool isBlades;

	//if this script is attached to the top part, this variable must be set to true
	public bool isTopPart;

	
	// Update is called once per frame
	void Update () {
	
		//if isBlades is set to true call the RotateBlades() method
		//else if isTopPart is set to true call the RotateTopPart() method
		if (isBlades) {
			RotateBlades ();
		} else if (isTopPart) {
			RotateTopPart ();
		}

	}


	public void RotateBlades()
	{
		transform.Rotate(Vector3.right * Time.deltaTime * GlobalVariables.speed);
	}

	public void RotateTopPart()
	{
		transform.localEulerAngles = new Vector3(0f,GlobalVariables.angle,0f);
	}



}
