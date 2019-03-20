using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

		Animator anim;
		CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		void Start () {
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){
			if (Input.GetKey (KeyCode.W)) {
				anim.SetInteger("AnimationPar", 1);
			}  else {
				anim.SetInteger("AnimationPar", 0);
			}

            if (Input.GetKey (KeyCode.Z)) {
                anim.SetInteger("Flippy", 1);
            } else {
                anim.SetInteger("Flippy", 0);
            }

			if(controller.isGrounded){
				moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
			}

			float turn = Input.GetAxis("Horizontal");
			transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
			controller.Move(moveDirection * Time.deltaTime);
			moveDirection.y -= gravity * Time.deltaTime;
		}
}
