using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class TankScript : MonoBehaviour
{
    public GameObject W;
    public GameObject A;
    public GameObject S;
    public GameObject D;
    public GameObject tank;
    public GameObject placeW;
    public GameObject placeA;
    public GameObject placeS;
    public GameObject placeD;
    public GameObject tile;

    float speed = 0.3f;

    private void Start()
    {
        
    }
    private void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown("UpBtn"))
        {
            tank.transform.Translate(0, speed /** Time.deltaTime*/, 0);
            W.SetActive(true);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(false);
        }
        else if (CrossPlatformInputManager.GetButtonDown("DownBtn"))
        {
            tank.transform.Translate(0, -speed /** Time.deltaTime*/, 0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(true);
            D.SetActive(false);
        }
        else if (CrossPlatformInputManager.GetButtonDown("LeftBtn"))
        {
            tank.transform.Translate(-speed /** Time.deltaTime*/, 0 , 0);
            W.SetActive(false);
            A.SetActive(true);
            S.SetActive(false);
            D.SetActive(false);
        }
        else if (CrossPlatformInputManager.GetButtonDown("RightBtn"))
        {
            tank.transform.Translate(speed /** Time.deltaTime*/,0,  0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(true);
        }

        if(CrossPlatformInputManager.GetButtonDown("FireBtn"))
        {
            if(W.active)
            {

            }
            else if(A.active)
            {

            }
            else if(S.active)
            {

            }
            else if(D.active)
            {

            }
        }
    }
}