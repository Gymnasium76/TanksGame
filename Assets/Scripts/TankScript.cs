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
        //Debug.Log("SALAM");
        if(CrossPlatformInputManager.GetButtonDown("FireBtn"))
        {
            Debug.Log("PRIVET");
            if (W.activeSelf)
            {
                Debug.Log("ACTIVE");
                SpawnRot = placeW.transform.rotation;
                Vector3 SpawnPoint = placeW.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.up * 20, ForceMode.Impulse);
                Destroy(FireScr, 0.2f);
            }
            else if(A.activeSelf)
            {
                SpawnRot = placeA.transform.rotation;
                Vector3 SpawnPoint = placeA.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.right * -20, ForceMode.Impulse);
                Destroy(FireScr, 0.2f);
            }
            else if(S.activeSelf)
            {
                SpawnRot = placeS.transform.rotation;
                Vector3 SpawnPoint = placeS.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.up * -20, ForceMode.Impulse);
                Destroy(FireScr, 0.2f);
            }
            else if(D.activeSelf)
            {
                SpawnRot = placeD.transform.rotation;
                Vector3 SpawnPoint = placeD.transform.position;
                GameObject FireScr = Instantiate(tile, SpawnPoint, SpawnRot) as GameObject;
                Rigidbody Run = FireScr.GetComponent<Rigidbody>();
                Run.AddForce(FireScr.transform.right * 20, ForceMode.Impulse);
                Destroy(FireScr, 0.2f);
            }
        }
    }
}