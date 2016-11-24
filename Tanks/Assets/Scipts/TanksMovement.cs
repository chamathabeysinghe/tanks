using UnityEngine;
using System.Collections;

public class TanksMovement : MonoBehaviour {

    // Use this for initialization
    int x = 0;
    int y = 0;
   

    int currentDirection=0;

    void Start () {
        GameObject thePlayer = GameObject.Find("GameManager");
        PlaneGenerator generatorScript = thePlayer.GetComponent<PlaneGenerator>();
        x = (generatorScript.row-1) * 10;
        y = (generatorScript.col-1) * 10;
    }

    // Update is called once per frame
    void Update () {


        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x - 10;
            if (position.x < 0) return;
            this.transform.position = position;

            int requiredDirection = 270;
            int rightAngle = 360 - requiredDirection + currentDirection;
            int leftAngle = requiredDirection - currentDirection;

            int turnAngle = (rightAngle < leftAngle) ? rightAngle * -1 : leftAngle;

            currentDirection = requiredDirection;



            transform.Rotate(0, turnAngle, 0);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x = position.x + 10;
            if (position.x > x) return;
            this.transform.position = position;


            int requiredDirection = 90;
            int rightAngle = 360 - requiredDirection + currentDirection;
            int leftAngle = requiredDirection - currentDirection;

            int turnAngle = (rightAngle < leftAngle) ? rightAngle * -1 : leftAngle;

            currentDirection = requiredDirection;

            transform.Rotate(0, turnAngle, 0);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z + 10;
            if (position.z > y) return;
            this.transform.position = position;

            int requiredDirection = 0;
            int rightAngle = 360 - requiredDirection + currentDirection;
            int leftAngle = requiredDirection - currentDirection;

            int turnAngle = (rightAngle < leftAngle) ? rightAngle * -1 : leftAngle;

            currentDirection = requiredDirection;

            transform.Rotate(0, turnAngle, 0);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z = position.z - 10;
            if (position.z < 0) return;
            this.transform.position = position;

            int requiredDirection = 180;
            int rightAngle = 360 - requiredDirection + currentDirection;
            int leftAngle = requiredDirection - currentDirection;

            int turnAngle = (rightAngle < leftAngle) ? rightAngle * -1 : leftAngle;

            currentDirection = requiredDirection;

            transform.Rotate(0, turnAngle, 0);
        }
    }
    void FixedUpdate()
    {

    }
}
