using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    private int lives = 3;

    [SerializeField]
    private string name = "Mario";

    [SerializeField]
    private float jumpHeight = 5, speed = 5;

    private bool hasKey;

    private bool isOnGround;

    private Rigidbody2D rigidbody2DInstance;
    private float horizontalInput;

	// Use this for initialization
	void Start ()
    {
        // We have to initialize our rigidbody variable!
        rigidbody2DInstance = GetComponent<Rigidbody2D>();      
	}
	
	// Update is called once per frame
	private void Update ()
    {
        // Don't use Translate, because we're using physics!
        // transform.Translate(0, -.01f, 0); 

        GetInput();
        Move();
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        rigidbody2DInstance.velocity = new Vector2(horizontalInput, 0);
    }
}
