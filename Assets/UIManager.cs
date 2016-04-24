using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public void goToJetpackSelection(){
		Application.LoadLevel ("JetpackSelection");
	}

	public void goToTitleScreen(){
		Application.LoadLevel ("TitleScreen");
	}

	public void goToGame (int jetpackId){
		PlayerPrefs.SetInt ("selectedJetpack", jetpackId);
		Application.LoadLevel ("JetpackRun");
	}
}
