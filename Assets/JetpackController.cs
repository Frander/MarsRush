using UnityEngine;
using System.Collections;
using ProgressBar;
using UnityEngine.UI;

public class JetpackController : MonoBehaviour {

	public static float jetpackForce;
	bool jetpackActive;
	public ParticleSystem jetpack;
	public Animator animator;
	public GameObject GOPanel;
	public GameObject succedPanel;
	bool grounded, dead = false;
	public AudioSource jetpackAudio;
	public static int jetpackUse;
	public static int attemps;

	//statics
	public Text timeTxt;
	public Text distanceTxt;
	public Text attempsTxt;
	public Text jetpackUseTxt;
	public Text totalPoins;

	public ProgressBarBehaviour BarBehaviour;
	float time;
	float UpdateDelay = 2f;

	//variables
	public static int fluelConsume;

	public void useJetpack(){
		jetpackActive = true;
		jetpackUse++;
	}

	public void cancelJetpack(){
		jetpackActive = false;
	}

	// Use this for initialization
	void Start () {
		BarBehaviour.Value = 100;
		jetpackUse = 0;
		attemps = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate ()
	{

		
		if (jetpackActive)
		{
			time += Time.deltaTime;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
			//2
			animator.SetBool("ground", false);
			grounded = false;
			if (time > 0.5) {
				BarBehaviour.Value = BarBehaviour.Value - fluelConsume;
				time = 0;
				if (BarBehaviour.Value == 0) {
					dead = true;
					GOPanel.SetActive (true);
					Time.timeScale = 0;
				}
			}

		}

		AdjustJetpack(jetpackActive);

		AdjustFootstepsAndJetpackSound(jetpackActive);
	}

	public void setStatics(){
		timeTxt.text = timer.totalTime.ToString();
		distanceTxt.text = distanceCalculator.totalDistance.ToString();
		attempsTxt.text = attemps.ToString();
		jetpackUseTxt.text = jetpackUse.ToString();
		float total = Mathf.Round(timer.totalTime * 20f);
		totalPoins.text = total.ToString();
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag ("deathZone")) {
			attemps++;
			dead = true;
			GOPanel.SetActive (true);
			Time.timeScale = 0;
		}

		if (col.gameObject.CompareTag ("goal")) {
			succedPanel.SetActive (true);
		}
	}

	void OnCollisionStay2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("ground"))
		{
			animator.SetBool("ground", true);
			grounded = true;
		}
		
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("ground"))
		{
			animator.SetBool("ground", false);
			grounded = false;
		}

	}

	void AdjustJetpack (bool jetpackActive)
	{
		jetpack.enableEmission = !grounded;
		jetpack.emissionRate = jetpackActive ? 1000.0f : 500.0f; 
	}

	void AdjustFootstepsAndJetpackSound(bool jetpackActive)    
	{
		jetpackAudio.enabled = !dead && !grounded;
		jetpackAudio.volume = jetpackActive ? 1.0f : 0.5f;        
	}


}
