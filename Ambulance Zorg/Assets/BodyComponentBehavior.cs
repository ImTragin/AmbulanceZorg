using UnityEngine;
using System.Collections;

public class BodyComponentBehavior : MonoBehaviour {

	public GameObject requiredItem = null;
	private GameObject equippedItem;

	public NurseBehavior nurseScript;
	public PatientBehavior patient;

	public bool partHealed;

	private Renderer render;
	public bool hurt;

	// Use this for initialization
	void Start () {

		render = GetComponent<Renderer>();

		if (hurt == true)
		{
			render.material.color = Color.black;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		equippedItem = nurseScript.itemUsing;

	}

	void OnMouseDown()
	{
		Debug.Log("you used me");

		//nurseScript.itemUsing = null;

		if (requiredItem == equippedItem)
		{
			isTreated();
		}
		else if (requiredItem != equippedItem)
		{
			patient.health -= 25 * patient.severity;
		}
	}

	void isTreated()
	{
		partHealed = true;
		render.material.color = Color.white;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.collider.tag == "CROWD")
		{
			patient.destroyMe();
		}
	}
}
