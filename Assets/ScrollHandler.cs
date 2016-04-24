using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollHandler : MonoBehaviour {

	private float[] normalizedPositions = {-1.033464E-06f, 0.4782742f, 1.054611f};
	private string[] names = {"Jet pack H202", "Jet pack H202-Z", "Jet pack T-73"};
	private string[] weights = {"30 KG", "45 KG", "34 KG"};
	private string[] fuels = {"Kerosene", "Hydrogen", "Jet-A-Fuel"};
	private string[] engines = {"Rocket Engine", "Rocket Engine", "T-73 Jet Motor"};

	private ScrollRect scroll;
	private int selectedItem = 0;

	public GameObject left, right;

	//Text components:
	public Text jpkName, jpkWeight, jpkFuel, jpkEngine;


	// Use this for initialization
	void Start () 
	{
		scroll = GetComponent<ScrollRect> ();
		selectedItem = 0;
		checkScrollChanges ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void checkScrollChanges()
	{
		if (selectedItem <= 0) 
		{
			left.SetActive (false);
		}

		else
			if(selectedItem >= (normalizedPositions.Length - 1) )
			{
				selectedItem = (normalizedPositions.Length - 1);
				right.SetActive (false);
			}
			
			else
			{
				left.SetActive (true);
				right.SetActive (true);			
			}

		//Set elements according to selected jetpack
		scroll.horizontalNormalizedPosition = normalizedPositions [selectedItem];
		jpkName.text = names [selectedItem];
		jpkWeight.text = weights [selectedItem];
		jpkFuel.text = fuels [selectedItem];
		jpkEngine.text = engines [selectedItem];

	}

	public void moveRight()
	{
		selectedItem++;
		Debug.Log ("Selected Item: " + selectedItem);
		checkScrollChanges ();
	}

	public void moveLeft()
	{
		selectedItem--;
		Debug.Log ("Selected Item: " + selectedItem);
		checkScrollChanges ();
	}		

}
