using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
	//Luc ban cua vien dan
	private float Force = 11f;
	public float rotateSpeed = 100f; // The speed at which the Stick rotates, in degrees per second
	public GameObject bulletPerfab;
	public Transform bulletSpawnPoint;
	GameObject childObject;
	void Start()
	{
		// Create a new GameObject with a sphere mesh
		childObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);

		// Set the parent of the childObject to an existing parent GameObject
		Transform parentTransform = gameObject.transform;
		childObject.transform.SetParent(parentTransform);

		// Set the position of the childObject relative to its parent
		childObject.transform.localPosition = new Vector3(0f, 0.5f, 0f);
		childObject.transform.localScale = new Vector3(0f, 0f, 1);
	}

	void Update()
	{
		float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
		if (rotation != 0)
		{
			rotation *= Time.deltaTime;

			Vector3 pivot = new Vector3(-9, -4f, 0);
			Vector3 vector = new Vector3(0, 0, -rotation);

			transform.RotateAround(pivot, vector, 0.3f);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
	}

	void Shoot()
	{
		GameObject bullet = Instantiate(bulletPerfab, childObject.transform.position, bulletSpawnPoint.rotation);
		Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
		rigidbody.AddForce(bulletSpawnPoint.up * Force, ForceMode2D.Impulse);
		GetComponent<AudioSource>().Play();
	}
}
