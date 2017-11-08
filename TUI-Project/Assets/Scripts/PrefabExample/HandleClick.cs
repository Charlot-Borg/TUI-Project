using UnityEngine;
using System.Collections;

public class HandleClick : MonoBehaviour {

	//a public variable which will contain the prefab
	public Transform prefab;

	//this method is executed when a click on the object is detected
	void OnMouseDown()
	{
		//a vector3 object containing the position
		Vector3 position = new Vector3 (0, 0, 0);

		// a quaternion object containing the rotation angles
		Quaternion rotation = new Quaternion (0, 0, 0, 0);

		// the command used to create a copy of the prefab during runtime
		Instantiate (prefab, position, rotation);
	}



}
