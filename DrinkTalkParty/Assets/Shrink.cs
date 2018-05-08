using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Shrink : MonoBehaviour {
    float ticker = 30f;
    float mod;
    // Use this for initialization
	void Start () {
        mod = Random.Range(0.999f, 1.001f);
        Destroy(this.gameObject, ticker);
    }
	
	// Update is called once per frame
	void Update () {
        ticker -= Time.deltaTime;
        if (ticker > 27f)
        {
            this.transform.localScale *= 1.003f * mod;
        }
        else
        {
            this.transform.localScale *= .998f * mod;
        }
	}
}
