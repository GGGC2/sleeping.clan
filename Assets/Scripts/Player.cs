using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	public Animator animator;
	public int maxHealth;
	public int currentHealth;
	public int attack;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if(currentHealth <= 0) gameObject.SetActive(false);
		
	}
	public void HurtPlayer(int damage)
	{
		currentHealth -= damage;
	}

	public void SetMaxHealth()
	{
		currentHealth = maxHealth;
	}
}
