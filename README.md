# Unity-Learning-Notes
Unity notes. Not a tutorial/guide. Simply a collection of useful code and observations to help explore game development. 
<details> 
	<summary><h2> 2D Movements (Simple) </h2> </summary>
	Select new project (2D Core). 
<details> 
	<summary> <h3>Left/Right with RigidBody2D</h3></summary>
	
1. After creating a player and platform, add components "Rigidbody 2D" for the sprite, and "BoxCollision 2D" for both player and platform (Remember to tag the sprite as "player"). <br>
2. Add new script/component for Player. I named it `playerMovement` in below code. <br>
- Player components: Rigidbody2D, BoxCollision2D, playerMovement (C# script)  <br> 
- Platform/Ground components: BoxCollision2D <br>
The default compiler (ex: VSC) should open for code editing purposes. <br>

The following code, using Rigidbody2D, gives left/right movements via arrow keys:
```cs
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
```
`MonoBehavior` provides a "template script". This allows script to be attached to a game object in the editor. <br>
`public` fields appear in Unity's inspector. For example, in above code, `Speed` is able to be changed (higher number the faster). `private` fields (ex: Move), doesn't appear in the inspector. <br> <br> 
This gives the simple left/right movement with arrow keys.
</details>
</details>
