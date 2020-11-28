using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public int size;
    private Vector3[,] pos;

    public GameObject Stone;
    public GameObject Cactus;
    public GameObject Bush;

    public float heightpoint, heightpoint2;

    // Start is called before the first frame update
    void Start()
    {
        Generate();
    }
    /*IEnumerator AddBonus()
    {
        GameObject clone = Instantiate(_bonus) as GameObject;
        clone.transform.position = pos[Random.Range(0, size), Random.Range(0, size)];
        yield return new WaitForSeconds(timeoutBonus);
        if (!lose) StartCoroutine(AddBonus());
    }*/

    // Update is called once per frame
    void Generate()
    {
        for (int i = 0; i < Random.Range(2, 6); ++i)
        {
            Debug.Log("TUTA");
            GameObject clone = Instantiate(Stone) as GameObject;
            clone.transform.Translate(Random.Range(-1,size), Random.Range(-1,size), 0);
            //clone.transform.position = pos[1, 2];
            Debug.Log("STONE");
        }
        for (int i = 0; i < Random.Range(2, 4); ++i)
        {
            GameObject clone = Instantiate(Bush) as GameObject;
            clone.transform.Translate(Random.Range(-1, size), Random.Range(-1, size), 0);
            Debug.Log("Bush");
        }
        for (int i = 0; i < Random.Range(2, 5); ++i)
        {
            GameObject clone = Instantiate(Cactus) as GameObject;
            clone.transform.Translate(Random.Range(-1, size), Random.Range(-1, size), 0);
        }
    }
}
