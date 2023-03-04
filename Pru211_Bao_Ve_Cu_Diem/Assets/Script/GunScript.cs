using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunScript : MonoBehaviour
{


	public GameObject bulletPerfab;

	public Transform bulletSpawnPoint;

	GameObject childObject;

	Timer timer;

	private int maxBullet = 10; //maximum the bullet fire
	private int cooldownTime = 2; //time for cooldown fill max bullet
	private bool isCooldown = false; //status of cooldown
	private float bulletSpeed = 10f; //bullet force
	public float rotateSpeed = 100f; // The speed at which the Stick rotates, in degrees per second
	public TextMeshProUGUI bulletNumberText; //display bullet number
	public TextMeshProUGUI cooldownDisplay; //display time for cooldown
	void Start()
	{
		//the vertex for shoots a bullet 
		Transform parentTransform = gameObject.transform;
		childObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		childObject.transform.SetParent(parentTransform);
		childObject.transform.localPosition = new Vector3(0f, 0.5f, 0f);
		childObject.transform.localScale = new Vector3(0f, 0f, 1);

		//timer set cooldown for fill bullet
		timer = GetComponent<Timer>();
		timer.Duration = cooldownTime;
	}

	void Update()
	{
		processTextDisplay();



		if (Input.GetMouseButtonDown(1))
		{
			// Get the mouse position in world coordinates
			Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); ;
			GameObject bullet = Instantiate(bulletPerfab, mousePos, bulletSpawnPoint.rotation);
			Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
			rigidbody.AddForce(bulletSpawnPoint.up * bulletSpeed, ForceMode2D.Impulse);
			GetComponent<AudioSource>().Play();
			Vector3 pivot = new Vector3(-9, -4f, 0);
			// Calculate the direction from the pivot to the mouse position
			Vector3 direction = pivot - mousePos;

			// Calculate the angle of rotation in degrees using the Atan2 function
			float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

			// Rotate the object around the pivot using the calculated angle
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (maxBullet > 0)
			{
				Shoot();
				maxBullet--;
			}
		}
	}

	void Shoot()
	{
		GameObject bullet = Instantiate(bulletPerfab, childObject.transform.position, bulletSpawnPoint.rotation);
		Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
		rigidbody.AddForce(bulletSpawnPoint.up * bulletSpeed, ForceMode2D.Impulse);
		GetComponent<AudioSource>().Play();
	}

	void processTextDisplay()
	{

		if (maxBullet <= 0)
		{
			bulletNumberText.text = "";
			cooldownDisplay.text = "Nạp đạn: " + timer.elapsedSeconds.ToString().Substring(0, 1) + "/" + cooldownTime + " giây";
			if (!isCooldown)
			{
				timer.run();
				isCooldown = true;
			}
			if (timer.Finished)
			{
				maxBullet = 10;
				isCooldown = false;
			}
		}
		else
		{
			cooldownDisplay.text = "";
			bulletNumberText.text = maxBullet < 0 ? "0" : maxBullet + " Viên";
		}
	}
}
