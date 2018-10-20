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
		Player myPlayer = new Player();
		myPlayer.Attack();
		myPlayer.Damage(30);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
