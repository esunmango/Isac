﻿using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class BulletScript : MonoBehaviour {

    public float range = 20;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject o = collision.gameObject;
        if (o.CompareTag("Enemy"))
        {
            o.GetComponentInParent<Enemy>().Health--;
        }
		GameObject pc = GameObject.FindWithTag ("Player");
		pc.GetComponent<PlayerShootController>().BulletCollideClip.Play ();
		Destroy(gameObject);
    }
    private Vector2 _start;

    public void Start()
    {
		if (this.gameObject.CompareTag ("Enemy")) {
			this.gameObject.layer = 13;
		}
		_start = new Vector2(transform.position.x, transform.position.y);
        GameObject p = GameObject.FindWithTag("Player");
        Player pc = p.GetComponent<Player>();
        range = pc.Range;
    }
	public void Update () {
	    if ( Mathf.Abs(_start.x - transform.position.x) > range || Mathf.Abs(_start.y -transform.position.y) > range )
	    {
	        Destroy(gameObject);
	    }
	}
}
    