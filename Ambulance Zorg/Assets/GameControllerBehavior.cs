using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameControllerBehavior : MonoBehaviour {

    public Text patientZeroHealth;
    public Text patientTwoHealth;
    public Text patientThreeHealth;

    public PatientBehavior patient_1;
    public PatientBehavior patient_2;
    public PatientBehavior patient_3;

    // Use this for initialization
    void Start () {

		Cursor.lockState = CursorLockMode.Locked;
        

    }
	
	// Update is called once per frame
	void Update () {

        updateHealth ();
	
	}

    void updateHealth()
    {
        patientZeroHealth.text = "Patient one health : " + patient_1.health.ToString("N0");
        patientTwoHealth.text = "Patient two health : " + patient_2.health.ToString("N0");
        patientThreeHealth.text = "Patient three health : " + patient_3.health.ToString("N0");
    }
}
