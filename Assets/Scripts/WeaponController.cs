using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float fireDelay;

    public GameObject shot2;
    public Transform shotSpawn2;


    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        InvokeRepeating("Fire", fireDelay, fireRate);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Fire()
    {
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        Instantiate(shot2, shotSpawn2.position, shotSpawn2.rotation);
        audioSource.Play();
    }
}
