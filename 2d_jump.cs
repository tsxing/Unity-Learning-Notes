using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

   [SerializeField] float jumpForce = 10;
   Rigidbody2D rb; 
   void Start()
   {
   	rb = GetComponent<Rigidbody2D>();
   }

   void Update()
   {
   	if (Input.GetKeyDown(KeyCode.Space))
       {
   		rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
       }

   }
}
