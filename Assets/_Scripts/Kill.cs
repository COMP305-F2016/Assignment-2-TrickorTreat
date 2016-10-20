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
