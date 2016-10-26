///-----------------------------------------------------------------
///   Namespace:      COMP305-F2016-Assignment2-TrickOrTreat
///   Class:          EnemyController
///   Description:    This controls the Enemy behavior 
///   Author:         Angela Liu                    Date: October 16,2016
///   Notes:          Enemy controller
///   Revision History: V1.0
///   Name: Angela          Date: Oct 16,2016        Description:
///-----------------------------------------------------------------
using UnityEngine;
using System.Collections;

public class CheckPointContoller : MonoBehaviour {
    // PRIVATE INSTANCE VARIABLES
    private Transform _transform;

    // PUBLIC INSTANCE VARIABLES (FOR TESTING)

    public GameObject SpawnPoint;


    // Use this for initialization
    void Start()
    {
        this._transform = GetComponent<Transform>();
        this.SpawnPoint = GameObject.FindWithTag("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.SpawnPoint.transform.position = this._transform.position;
        }
    }
}
