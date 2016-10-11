using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PatientBehavior : MonoBehaviour {

	public GameControllerBehavior controller;

	//Handling of the health
	public float health = 100;
	public float severity;

	//All body components that need to be healthy
	public BodyComponentBehavior com_1;
	public BodyComponentBehavior com_2;
	public BodyComponentBehavior com_3;
	public BodyComponentBehavior com_4;
	public BodyComponentBehavior com_5;
	public BodyComponentBehavior com_6;

	//When healed
	public bool isHealed;

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void FixedUpdate () {

		if (com_1.partHealed == true && com_2.partHealed == true && com_3.partHealed == true && com_4.partHealed == true 
			&& com_5.partHealed == true && com_6.partHealed == true)
		{
			isHealed = true;
		}


		if (isHealed == true && health >= 0)
		{
			startMoving();
		}


		if (health < 0)
		{
			transform.Translate(transform.position.x, transform.position.y - 6, transform.position.z, Space.Self);
			transform.Rotate(90, transform.rotation.y , transform.rotation.z , Space.Self);
			health = 0;
			severity = 0;
		}

		health -= Time.deltaTime * severity;

	}


	void startMoving()
	{
		transform.Translate(Vector3.back * Time.deltaTime * 10, Space.Self);
	}

	public void destroyMe()
	{
		Destroy(gameObject); 
	}

}
