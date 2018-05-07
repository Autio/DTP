using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Note")
        {
            if(Random.Range(0,10) < 5)
            {/*
                Debug.Log("hit!");

                // destroy glass (only glass)
                Destroy(this.transform.Find("base").gameObject);
                Destroy(this.transform.Find("PintWall1").gameObject);
                Destroy(this.transform.Find("PintWall2").gameObject);
                Destroy(this.transform.Find("PintWall3").gameObject);
                Destroy(this.transform.Find("PintWall4").gameObject);
                Destroy(this.transform.Find("PintSprite").gameObject);
                */
            }
                   
        }
    }
}
