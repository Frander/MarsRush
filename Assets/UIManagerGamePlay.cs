using UnityEngine;
using System.Collections;

public class UIManagerGamePlay : MonoBehaviour {

	public GameObject pausePanel;
	public GameObject GOPanel;
	public GameObject gameSuccedPanel;

	public void resume(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);

	}

	public void pause(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void exit(){
		Time.timeScale = 1;
		Application.LoadLevel ("TitleScreen");
	}

	public void tryAgain(){
		Time.timeScale = 1;
		Application.LoadLevel ("JetpackRun");
	}
}
