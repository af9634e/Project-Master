using UnityEngine;
using System.Collections;

public class moveSteve : MonoBehaviour {
	float timeCheck = 1f;
	float timePassed;
	public Transform target;

	NavMeshAgent na;

	// Use this for initialization
	void Start () {
		na = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (timePassed > timeCheck) {
			timePassed = 0f;
			na.SetDestination (target.position);
		}
		timePassed += Time.deltaTime;
	}
		
}
