using UnityEngine;
using System.Collections;

public class JetpackChanger : MonoBehaviour {

	public Sprite[] jetpackSprites;
	private int selJetpack;

	// Use this for initialization
	void Start () 
	{
		selJetpack = PlayerPrefs.GetInt ("selectedJetpack", 0);
		GetComponent<SpriteRenderer>().sprite = jetpackSprites[selJetpack];
		switch (selJetpack) {
			case 0:
				{
					JetpackController.fluelConsume = 2;
					JetpackController.jetpackForce = 90;
					AutomaticRun.velocity = 40;
					AutomaticRun.skyLimit = 80;
					break;
				}
			case 1:
				{
					JetpackController.fluelConsume = 3;
					JetpackController.jetpackForce = 120;
					AutomaticRun.velocity = 30;
					AutomaticRun.skyLimit = 70;
					break;
				}
			case 2:
				{
					JetpackController.fluelConsume = 1;
					JetpackController.jetpackForce = 100;
					AutomaticRun.velocity = 20;
					AutomaticRun.skyLimit = 80;
					break;
				}
		}
	}

}
