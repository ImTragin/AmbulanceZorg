using UnityEngine;
using System.Collections;

public class NurseBehavior : MonoBehaviour {

	public GameObject itemUsing = null;
	private Vector3 itemPos;

	public float speed = 10.0f;
	public float lookSpeed = 5.0f;

	Vector3 xRotation = Vector3.zero;
	Vector3 yRotation = Vector3.zero;

	public Camera cam;

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {

		itemPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);

		//Position of the item currently being used
		if (itemUsing != null)
		{
			itemUsing.transform.position = itemPos;
			itemUsing.transform.rotation = cam.transform.rotation;
		}


		//For movement
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
		}

		if (Input.GetKey(KeyCode.E))
		{
			itemUsing = null;
		}


		//for camera movement and rotation

		float yRot = Input.GetAxisRaw("Mouse X");
		yRotation = new Vector3(0f, yRot, 0f * lookSpeed);

		float xRot = Input.GetAxisRaw("Mouse Y");
		xRotation = new Vector3(xRot, 0f, 0f) * lookSpeed;
	}


	void FixedUpdate()
	{
		performCamRotation();
	}


	void performCamRotation()
	{
		cam.transform.Rotate(-xRotation);
		transform.Rotate(yRotation);
	}

}
