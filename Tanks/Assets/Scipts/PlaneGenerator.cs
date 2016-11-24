using UnityEngine;
using System.Collections;

public class PlaneGenerator : MonoBehaviour {
    public Transform[] gridPrefab;
    public int row = 4;
    public int col = 4;
 

 
	// Use this for initialization
	void Start () {
        for (int r = 0; r < row; r++)
        {
            for (int c = 0; c < col; c++)
            {
                Instantiate(gridPrefab[Random.Range(0,3)], new Vector3(r*10, 0, c*10), Quaternion.identity) ;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
