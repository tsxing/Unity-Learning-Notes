## 2D Movements (Simple)
Select new project (2D Core). 
### Left and Right

After creating a Sprite (player) and Platform, add components "Rigidbody 2D" for the sprite, and "BoxCollision 2D" for both sprite and platform (Remember to tag the sprite as "player"). 

The following code, using Rigidbody2D, gives left/right movements via arrow keys:
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
	private CharacterController player;

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
```
Player components: Rigidbody2D, BoxCollision2D, playerMovement (C# script) 
Platform/Ground components: BoxCollision2D

This gives the simple left/right movement with arrow keys. 
