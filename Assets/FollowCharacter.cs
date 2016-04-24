using UnityEngine;
using System.Collections;

public class FollowCharacter : MonoBehaviour {

	public Transform personaje;
	public float separacionX = 6f;
	public float separacionY = 3f;	
	public GameObject character;
	private float marginCamera = 0.001f;


	//public GameObject bullet;

	void Start(){

	}

	// Update is called once per frame
	void Update()
	{
		//transform.position = new Vector3 (character.transform.position.x + marginCamera, character.transform.position.y + marginCamera, transform.position.z);
		this.transform.position = new Vector3(personaje.position.x + separacionX, personaje.position.y + separacionY, transform.position.z);
	}
}
