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

    Quaternion SpawnRot;

    private bool UpChecker=false, LeftChecker=false, RightChecker=false, DownChecker=false;
    public static bool IsAttachedRight = false, IsAttachedLeft = false, IsAttachedUp = false, IsAttachedDown = false;

    public static float speed = 0.005f;

    private void Start()
    {

    }
    private void Update()
    {
        if(CrossPlatformInputManager.GetButtonDown("UpBtn"))
        {
            /*tank.transform.Translate(0, speed /** Time.deltaTime, 0);
            W.SetActive(true);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(false);*/
            UpChecker = true;
        }
        else if (CrossPlatformInputManager.GetButtonDown("DownBtn"))
        {
            /*tank.transform.Translate(0, -speed /** Time.deltaTime, 0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(true);
            D.SetActive(false);*/
            DownChecker = true;
        }
        else if (CrossPlatformInputManager.GetButtonDown("LeftBtn"))
        {
            /*tank.transform.Translate(-speed /** Time.deltaTime, 0 , 0);
            W.SetActive(false);
            A.SetActive(true);
            S.SetActive(false);
            D.SetActive(false);*/
            LeftChecker = true;
        }
        else if (CrossPlatformInputManager.GetButtonDown("RightBtn"))
        {
            /*tank.transform.Translate(speed /** Time.deltaTime,0,  0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(true);*/
            RightChecker = true;
        }
        //Debug.Log("SALAM");
        /////////////////////////////////////////////////////////////
        if(UpChecker==true)
        {
            tank.transform.Translate(0, speed /** Time.deltaTime*/, 0);
            W.SetActive(true);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(false);
        }
        else if(DownChecker==true)
        {
            tank.transform.Translate(0, -speed /** Time.deltaTime*/, 0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(true);
            D.SetActive(false);
        }
        else if(LeftChecker==true)
        {
            tank.transform.Translate(-speed /** Time.deltaTime*/, 0 , 0);
            W.SetActive(false);
            A.SetActive(true);
            S.SetActive(false);
            D.SetActive(false);
        }
        else if(RightChecker==true)
        {
            tank.transform.Translate(speed /** Time.deltaTime*/,0,  0);
            W.SetActive(false);
            A.SetActive(false);
            S.SetActive(false);
            D.SetActive(true);
        }
        //////////////////////////////////////////////////////////////
        if(CrossPlatformInputManager.GetButtonDown("FireBtn"))
        {
            if (W.activeSelf)
            {
                SpawnRot = placeW.transform.rotation;
                Vector3 SpawnPoint = placeW.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.up * 20, ForceMode.Impulse);
                //Destroy(FireScr, 0.2f);
            }
            else if(A.activeSelf)
            {
                SpawnRot = placeA.transform.rotation;
                Vector3 SpawnPoint = placeA.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.right * -20, ForceMode.Impulse);
                //Destroy(FireScr, 0.2f);
            }
            else if(S.activeSelf)
            {
                SpawnRot = placeS.transform.rotation;
                Vector3 SpawnPoint = placeS.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.up * -20, ForceMode.Impulse);
                //Destroy(FireScr, 0.2f);
            }
            else if(D.activeSelf)
            {
                SpawnRot = placeD.transform.rotation;
                Vector3 SpawnPoint = placeD.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.right * 20, ForceMode.Impulse);
                //Destroy(FireScr, 0.2f);
            }
        }
        ////////////////////////////////////////////////////
        if (CrossPlatformInputManager.GetButtonUp("UpBtn"))
        {
            UpChecker = false;
        }
        else if (CrossPlatformInputManager.GetButtonUp("DownBtn"))
        {
            DownChecker = false;
        }
        else if (CrossPlatformInputManager.GetButtonUp("LeftBtn"))
        {
            LeftChecker = false;
        }
        else if (CrossPlatformInputManager.GetButtonUp("RightBtn"))
        {
            RightChecker = false;
        }
        ////////////////////////////////////////////////////////
        if(IsAttachedRight==true)
        {
            tank.transform.Translate(-0.03f, 0, 0);
        }
        else if(IsAttachedLeft==true)
        {
            tank.transform.Translate(0.03f, 0, 0);
        }
        else if(IsAttachedDown==true)
        {
            tank.transform.Translate(0, 0.03f, 0);
        }
        else if(IsAttachedUp==true)
        {
            tank.transform.Translate(0, -0.03f, 0);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        /*if (other.collider.tag != "Tile")
        {*/
            Debug.Log("PRIVET");
            speed = 0;
        //}
    }
}