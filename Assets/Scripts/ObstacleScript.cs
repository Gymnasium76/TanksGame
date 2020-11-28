using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("TEST");
        TankScript.bla= collision.contacts[0].point;
        TankScript.ColChecker = true;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        TankScript.ColChecker = false;    
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Tile1")
        {
            Debug.Log("SALAMAAA");
            Destroy(other.gameObject);
            Destroy(other.transform.parent.gameObject);
            Debug.Log(other.name);
        }
    }
}
