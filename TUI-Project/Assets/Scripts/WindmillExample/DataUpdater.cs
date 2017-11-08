using UnityEngine;
using System.Collections;

public class DataUpdater : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		// if the indicator cube is visible, call the methods to calculate the speed and the angle
		if (GameObject.FindGameObjectWithTag ("Indicator").transform.GetChild (0).GetComponent<MeshRenderer> ().enabled) {
			CalculateSpeed ();
			CalculateAngle ();

		}

		// set the text object to be always at the same readable angle
		GameObject.FindGameObjectWithTag ("SpeedText").transform.eulerAngles = new Vector3 (0, 0, 0);

	}


	//this method is used to calculate the speed of the blades
	private void CalculateSpeed()
	{
		Quaternion target = GameObject.FindGameObjectWithTag ("Indicator").transform.localRotation;
		float speed = target.eulerAngles.z *2;

		//set the value of the global variable speed
		GlobalVariables.speed = speed;

		//this variable will contain the speed as a whole number
		int roundedSpeed = (int)speed;
		roundedSpeed = roundedSpeed / 10;

		//set the text of the indicator object
		GameObject.FindGameObjectWithTag ("SpeedText").GetComponent<TextMesh> ().text = roundedSpeed.ToString ();
	}

	//this method is used to calculate the angle of the top part
	private void CalculateAngle()
	{
		//vec1 will contain the position of the top part
		Vector3 vec1 = transform.position;

		//vec2 will contain the position of the indicator
		Vector3 vec2 = GameObject.FindGameObjectWithTag ("Indicator").transform.position;


		float angle = AngleInDeg (vec1, vec2);

		//set the global variable containing the angle of the top part
		GlobalVariables.angle = angle*-1;

	}


	private float AngleInRad(Vector3 vec1, Vector3 vec2) {
		return Mathf.Atan2(vec2.y - vec1.y, vec2.x - vec1.x);
	}

	//This returns the angle in degrees
	private float AngleInDeg(Vector3 vec1, Vector3 vec2) {
		return AngleInRad(vec1, vec2) * 180 / Mathf.PI;
	}
}
