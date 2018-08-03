using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : MonoBehaviour {

    Rigidbody2D _body;

	private void Awake()
	{
        _body = GetComponent<Rigidbody2D>();
	}

	[SerializeField] float mJumpHeight = 0.00001f;
    [SerializeField] float mMoveSpeed = 1.0f;

    public void Jump() {
        _body.AddForce(Vector2.up*mJumpHeight, ForceMode2D.Impulse);
    }


    public void Move(float horizontalDir)
	{
        /*
        Vector2 pos2D = transform.position;
        Vector2 newPos = pos2D + Time.deltaTime * horizontalDir * Vector2.right;
        _body.MovePosition(newPos);*/
        _body.AddForce(horizontalDir * Vector2.right*mMoveSpeed, ForceMode2D.Force);
	}
}
