using UnityEngine;
using System.Collections;

public class playVideo : MonoBehaviour {

	private string mp4Url = "intro.mp4";

	// Use this for initialization
	void Start () {
		StartCoroutine(PlayMovie());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	protected IEnumerator PlayMovie(){ 

		Debug.Log("Entroooooo");
		Handheld.PlayFullScreenMovie (mp4Url, Color.black, FullScreenMovieControlMode.Hidden);
		//Handheld.PlayFullScreenMovie ("ceelo.mp4", Color.black, FullScreenMovieControlMode.Hidden);	
		//BackToScene ();
		yield return new WaitForSeconds (0.01f);
		Debug.Log("Terminooooo");
		Application.LoadLevel ("TitleScreen");

	}
}
