using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	public float Speed;
	private float Move;

	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		Move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(Move * Speed, rb.velocity.y);
	}
}
