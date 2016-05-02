 using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;
    private float time;
    private float timeToDestroy = 2;
    private GameObject ball;
    private bool clockIsOn =  false;
    public int points; 
 
    private int x;
    private int y;

    void Start () {
        x = Screen.width / 2;
        y = Screen.height / 2;
        points = 0;

    }

    void Update () {
        ray = Camera.main.ScreenPointToRay(new Vector3(x, y));
        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);
       // time = Time.time;
        if (Physics.Raycast(ray, out hit, 100)) {
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
            Debug.Log("tempo = " + time);
           // Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "bola")
            {
                if (!clockIsOn)
                {
                    clockIsOn = true;
                    startClock();
                }
                if (clockIsOn && Time.time - time >= timeToDestroy)
                {
                    Debug.Log("ta apontando para bola");
                    Destroy(hit.collider.gameObject);
                    points += 10; 

                    clockIsOn = false;
                }

            }
            else clockIsOn = false;
        }
    }

    private void startClock()
    {
        time = Time.time; 
    }
}
