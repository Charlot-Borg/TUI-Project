using UnityEngine;
using System.Collections;

public class MultipleCameraExample_script : MonoBehaviour {

	//this method is executed when a click on the object is detected
	void OnMouseDown()
	{
		//write the name of the onbject clicked to the console
		Debug.Log(gameObject.name + " was clicked");
	}
}
