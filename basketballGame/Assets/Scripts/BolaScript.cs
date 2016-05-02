using UnityEngine;
using System.Collections;

public class BolaScript : MonoBehaviour {
    public GameObject player;
    public float controle;
    public ForceMode mode;

    private SoundManager soundManager;
	
	void Start () {
        soundManager = FindObjectOfType(typeof(SoundManager)) as SoundManager;
        GetComponent<Rigidbody>().AddForce(player.transform.position*controle, mode ); 
	}

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "chao")
        {
            soundManager.playBounce();
        }
    }
    void Update () {
	}
}
