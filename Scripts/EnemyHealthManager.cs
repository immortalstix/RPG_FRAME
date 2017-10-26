using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

	public int MaxHealth;
	public int CurrentHealth;


	// Use this for initialization
	void Start () {
		CurrentHealth = MaxHealth;
	}

	// Update is called once per frame
	void Update () {
		if (CurrentHealth <= 0) 
		{
			Destroy (gameObject);
		}
	}

	public void HurtEnemy(int damageToGive)// int damage amount
	{
		CurrentHealth -= damageToGive; // '-=' is same as writing CurrentHealth = CurrentHealth - damageToGive
	}

	public void SetMaxHealth()
	{
		CurrentHealth = MaxHealth;
	}
}