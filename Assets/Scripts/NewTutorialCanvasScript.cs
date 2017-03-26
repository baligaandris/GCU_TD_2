using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTutorialCanvasScript : MonoBehaviour {
	public GameObject welcomeMessage;
	public GameObject gifAnimation;
	public GameObject continueButton1;
	public GameObject continueButton2;
	public GameObject speakingStudent;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ContinueButtonClick() {
		
		if (continueButton1.activeInHierarchy)
        {
			gameObject.GetComponent<AudioSource> ().Play ();
			continueButton2.SetActive (true);
			continueButton1.SetActive (false);
            //gameObject.transform.parent.
			welcomeMessage.SetActive(false);
			gifAnimation.SetActive (true);
            //GameObject spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
            //spawnPoint.GetComponent<SpawnEnemy>().waveInProgress = true;
            //Time.timeScale = 0;
		//	GameObject spawnPoint = GameObject.FindGameObjectWithTag ("SpawnPoint");
			//spawnPoint.GetComponent<SpawnEnemy> ().waveInProgress = true;
		}
        else
        {
            //gameObject.transform.parent.
            gameObject.SetActive(true);
            //Time.timeScale = 1;
        }
    }

	public void SecondContinueButtonClicl(){
		if (continueButton2.activeInHierarchy && gifAnimation.activeInHierarchy) {
			gifAnimation.SetActive (false);
			continueButton2.SetActive (false);
			gameObject.GetComponent<AudioSource> ().Play ();
			speakingStudent.SetActive (false);

		}
	}

}
