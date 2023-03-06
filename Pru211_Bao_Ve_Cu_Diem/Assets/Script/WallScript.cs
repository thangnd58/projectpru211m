using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public float maxHealth = 100.0f;

	[SerializeField]
	GameObject explosionPrefab;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "BulletEnermy")
		{
			maxHealth--;
			Instantiate<GameObject>(explosionPrefab, collision.transform.position, Quaternion.identity);
			Destroy(collision.gameObject);
		}

	}

	private void Update()
	{
		if(maxHealth <= 0)
		{
			Time.timeScale = 0;
		}
	}
}
