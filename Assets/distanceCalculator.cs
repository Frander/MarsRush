using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class distanceCalculator : MonoBehaviour {

	public GameObject start;
	public GameObject astronaut;

	public static float totalDistance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var distance = Vector3.Distance(start.transform.position, astronaut.transform.position);
		GetComponent<Text> ().text = Mathf.Round(distance).ToString ();
		totalDistance = Mathf.Round (distance);
	}
}
