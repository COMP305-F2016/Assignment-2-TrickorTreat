///-----------------------------------------------------------------
///   Namespace:      COMP305-F2016-Assignment2-TrickOrTreat
///   Class:          MemuController
///   Description:    This controls the menu behavior 
///   Author:         Angela Liu                    Date: October 16,2016
///   Notes:          menu controller
///   Revision History: V1.0
///   Name: Angela          Date: Oct 16,2016        Description:
///-----------------------------------------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //PUBLIC METHODS
    public void StartButton_Click() {
        SceneManager.LoadScene("Play");
    }
}
