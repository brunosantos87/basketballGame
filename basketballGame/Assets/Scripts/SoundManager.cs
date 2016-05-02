using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
    public AudioSource[] bounces;
    private int random;


	void Start () {
	
	}
	
	void Update () {
        random = (int)Random.Range(0, bounces.Length);
	}

    public void playBounce()
    {
        bounces[random].Play();
    }
}
