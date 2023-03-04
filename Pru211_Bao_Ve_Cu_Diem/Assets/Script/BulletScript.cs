using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

	Rigidbody2D rb;

	[SerializeField]
	GameObject explosionPrefab;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Enermy")
		{
			Destroy(gameObject);
			Instantiate<GameObject>(explosionPrefab, transform.position, Quaternion.identity);
		}

	}

	// Start is called before the first frame update
	void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
