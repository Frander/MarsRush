using UnityEngine;
using System.Collections;

public class AutomaticRun : MonoBehaviour {

	public static float maxSpeed;
	public float minSpeed;
	public static float velocity = 20;

	float lastVelocity;
	public Animator animator;


	public bool showVelocity;
	public static bool move = true;

	private int tries;

	public static int skyLimit=60;
	public GameObject LimitCollider;

	Vector3 startPos;

	// Use this for initialization
	void Start () {
		move = true;

	}
	
	// Update is called once per frame
	void Update () {

		LimitCollider.transform.position = new Vector3 (this.transform.position.x, skyLimit, 0);

		if (move) {
			
			//if (lastVelocity < maxSpeed)
				GetComponent<Rigidbody2D> ().velocity = new Vector3(velocity, GetComponent<Rigidbody2D> ().velocity.y, 0);

			lastVelocity = GetComponent<Rigidbody2D> ().velocity.x;

			if (showVelocity)
				Debug.Log (lastVelocity);
		}

	
	}

	// Update is called once per frame
	void FixedUpdate () {




		//Debug.Log (move);

	}
}
