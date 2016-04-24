using UnityEngine;
using System.Collections;

public class Seguir : MonoBehaviour {

    public Transform personaje;
    public float separacionX = 6f;
	public float separacionY = 6f;

	public Animator cameraAnimator;
	public Rigidbody2D character;

	private bool zoomIn;
	private bool zoomOut;

	void Start()
	{
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(personaje.position.x + separacionX, personaje.position.y + separacionY, transform.position.z);
    }

}
