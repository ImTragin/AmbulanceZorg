using UnityEngine;
using System.Collections;

public class PatientBehavior : MonoBehaviour {

    public GameObject requiredItem;
    private GameObject equippedItem;

    public NurseBehavior nurseScript;
    public GameControllerBehavior controller;

    //Handling of the health
    public float health = 100;
    public float severity;

    //When healed
    public bool isHealed;

	// Use this for initialization
	void Start () {
	
	}
	

	// Update is called once per frame
	void FixedUpdate () {

        if (isHealed == true)
        {
            startMoving();
        }

        
        equippedItem = nurseScript.itemUsing;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        health -= Time.deltaTime * severity;

	}


    void OnMouseDown()
    {
        nurseScript.itemUsing = null;
        
        if (requiredItem == equippedItem)
        {
            isTreated();
        }
        else if (requiredItem != equippedItem)
        {
            health -= 50 * severity;
        }
    }


    void isTreated()
    {
        isHealed = true;        
    }


    void startMoving()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 10, Space.Self);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "CROWD")
        {
            Destroy(gameObject);
        }
    }

}
