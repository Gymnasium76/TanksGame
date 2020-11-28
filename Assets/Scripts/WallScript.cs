using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			TankScript.speed = 0;
		}
		if(gameObject.name=="Wall")
        {
			TankScript.IsAttachedLeft = true;
        }
		else if(gameObject.name=="Wall2")
        {
			TankScript.IsAttachedUp = true;
        }
		else if(gameObject.name=="Wall3")
        {
			TankScript.IsAttachedRight = true;
        }
		else if(gameObject.name=="Wall4")
		{
			TankScript.IsAttachedDown = true;
		}
        if (other.tag == "Tile1")
        {
            Debug.Log("SALAMAAA");
            Destroy(other.gameObject);
            Destroy(other.transform.parent.gameObject);
            Debug.Log(other.name);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (TankScript.IsAttachedRight == true)
        {
            TankScript.IsAttachedRight = false;
        }
        else if (TankScript.IsAttachedLeft == true)
        {
            TankScript.IsAttachedLeft = false;
        }
        else if (TankScript.IsAttachedDown == true)
        {
            TankScript.IsAttachedDown = false;
        }
        else if (TankScript.IsAttachedUp == true)
        {
            TankScript.IsAttachedUp = false;
        }
		TankScript.speed = 0.005f;
    }
}
