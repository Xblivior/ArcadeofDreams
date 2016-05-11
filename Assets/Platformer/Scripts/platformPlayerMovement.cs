using UnityEngine;
using System.Collections;

public class platformPlayerMovement : MonoBehaviour
{
	private Rigidbody2D myRigidbody;

	public GameObject gameController; 

	[SerializeField]
	private float moveSpeed;

	private bool facingRight;

	[SerializeField]
	private Transform[] groundPoints;

	[SerializeField]
	private float groundRadius;

	[SerializeField]
	private LayerMask whatIsGround;

	private bool isGrounded;

	private bool jump;

	[SerializeField]
	private float jumpForce;


	void Start () 
	{
		facingRight = true;
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		HandleInput();
	}

	void FixedUpdate () 
	{

		float horizontal = Input.GetAxis("Horizontal");

		isGrounded = IsGrounded();

		//shows what direction the character is moving via "values"
		Debug.Log(horizontal);

		HandleMovement(horizontal);

		Flip(horizontal);
	}

	private void HandleMovement(float horizontal)
	{
		
		myRigidbody.velocity = new Vector2(horizontal * moveSpeed, myRigidbody.velocity.y);

		if (isGrounded && jump)
		{
			isGrounded = false;
			myRigidbody.AddForce(new Vector2(0, jumpForce));
			jump = false;
		}
	}

	private void HandleInput()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			{
				jump = true;
			}
	}

	private void Flip(float horizontal)
	{
		if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
		{
			facingRight = !facingRight;

			Vector3 theScale = transform.localScale;

			theScale.x *= -1;

			transform.localScale = theScale;
		}
	}

	private bool IsGrounded()
	{
		if(myRigidbody.velocity.y <= 0)
		{
			foreach (Transform point in groundPoints)
			{
				Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

				for (int i = 0; i < colliders.Length; i++)
				{
					if(colliders[i].gameObject != gameObject)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "PlatformerThirdPlat")
		{
			Debug.Log("something");
			gameController.GetComponent<GameController>().Victory(); 
		}

	}
}


//Eugene