using UnityEngine;
using System.Collections;

public class Collisiontest : MonoBehaviour {

	//this method is executed when a click on the object is detected
	void OnCollisionEnter (Collision col)
	{
		//this is used to write a message in the console
		Debug.Log("Entered");
	}


	void Update()
	{
		//cheks if the W key is pressed
		if (Input.GetKeyDown ("w")) {
			
			//move the object forward
			transform.Translate(Vector3.forward * Time.deltaTime*10);
		}

		//cheks if the A key is pressed
		if (Input.GetKeyDown ("a")) {

			//move the object to the left
			transform.Translate(Vector3.left * Time.deltaTime*10);
		}

		//cheks if the S key is pressed
		if (Input.GetKeyDown ("s")) {

			//move the object backwards
			transform.Translate(Vector3.back * Time.deltaTime*10);
		}

		//cheks if the D key is pressed
		if (Input.GetKeyDown ("d")) {

			//move the object to the right
			transform.Translate(Vector3.right * Time.deltaTime*10);
		}
	}
}
