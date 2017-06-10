using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour {
	
	public int animalMaxHealth;
	public int animalCurrentHealth;
	public int animalAttack;
	public int animalAffection;

	// Use this for initialization
	void Start () {
		SetMaxHealth();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Damaged(int damage)
	{
		animalCurrentHealth -= damage;
	}
	
	public void SetAffection(int affection)
	{
		animalAffection = affection;
	}

	public void SetMaxHealth()
	{
		animalCurrentHealth = animalMaxHealth;
	}
}
