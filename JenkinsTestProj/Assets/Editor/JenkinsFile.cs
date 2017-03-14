using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class JenkinsFile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static bool KickOffBuild(){
		Debug.Log("I'm here");
		return false;
	}

}
