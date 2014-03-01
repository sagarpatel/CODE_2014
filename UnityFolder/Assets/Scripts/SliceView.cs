using UnityEngine;
using System.Collections;

public class SliceView : MonoBehaviour 
{

	public string independantVariable;
	public string dependantVariable;
	public int year;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void SetValues()
	{
		// get list of independantVariables based on string, ex: if independantVariable = "Manufacturer", the returned list should be "Acura, Aston Martin,..."

		// for each element in above list, get associated value for given year

		// use iTween to lerp gameobject scale to new value
	}


}
