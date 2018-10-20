using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

	private int hp = 100;
	private int power = 50;

	public void Attack() {
		Debug.Log(this.power + "のダメージを与えた");
	}

	public void Damage(int Damage)
	{
		this.hp -= Damage;
		Debug.Log(Damage + "のダメージを受けた");
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 startPos = new Vector2(2.0f, 1.0f);
		Vector2 endPos = new Vector2(8.0f, 5.0f);
		Vector2 dir = endPos - startPos;
		Debug.Log(dir);

		float len = dir.magnitude;
		Debug.Log(len);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
