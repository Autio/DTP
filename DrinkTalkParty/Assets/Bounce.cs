using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Bounce : MonoBehaviour {
    Vector3 oPos;
    public float offset = 0.5f;
    float time = 3.0f;
	// Use this for initialization
	void Start () {
        time *= Random.Range(0.8f, 1.2f);
        oPos = this.transform.position;
        Tween();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Tween()
    {
        Sequence pulse = DOTween.Sequence();
        pulse.Append(this.transform.DOLocalMoveY(-333 + offset, time));
        pulse.Append(this.transform.DOLocalMoveY(-333, time));
        pulse.SetLoops(-1, LoopType.Restart);
    }
}
