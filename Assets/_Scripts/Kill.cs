///-----------------------------------------------------------------
///   Namespace:      COMP305-F2016-Assignment2-TrickOrTreat
///   Class:          KillerController
///   Description:    This controls the Killbehavior 
///   Author:         Angela Liu                    Date: October 16,2016
///   Notes:          Killer controller
///   Revision History: V1.0
///   Name: Angela          Date: Oct 16,2016        Description:
///-----------------------------------------------------------------
using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            Destroy(this.gameObject);
        }
    }
}
