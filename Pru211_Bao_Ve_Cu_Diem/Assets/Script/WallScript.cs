using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public float maxHealth = 100.0f;
	private float healthLeft;
	[SerializeField]
	GameObject explosionPrefab;

	public TextMeshProUGUI healthDisplay;

	private void Start()
	{
		healthLeft = maxHealth;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "BulletEnermy")
		{
			healthLeft--;
			Instantiate<GameObject>(explosionPrefab, collision.transform.position, Quaternion.identity);
			Destroy(collision.gameObject);
		}

	}

	private void Update()
	{
		healthDisplay.text = "Hp: "+ healthLeft +"/100";
		if (healthLeft <= 0)
		{
			Time.timeScale = 0;
		}
	}
}
