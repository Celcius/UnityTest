using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputReader : MonoBehaviour {

    MyPlayerController mpc = null;
    bool mJumping = false;

	private void Start()
	{
        mpc = GetComponent<MyPlayerController>();
	}

	void Update () {
        if(mpc == null) {
            return;
        }

        mJumping |= Input.GetKey(KeyCode.Space);
            
	}

    void FixedUpdate()
    {
        if (mpc == null)
        {
            return;
        }

        if (mJumping)
        {
            mpc.Jump();
            mJumping = false;
        }

        mpc.Move(Input.GetAxis("Horizontal"));
    }
}
