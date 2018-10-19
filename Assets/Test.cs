using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void callName(string name)	{
		Debug.Log("Hello" + name);
	}
	// Use this for initialization
	void Start () {
		callName("kengo");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
