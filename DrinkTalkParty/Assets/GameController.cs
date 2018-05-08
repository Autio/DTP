using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    HumanSpawner humanSpawner;
    public GameObject note;
    public GameObject drink;
    int maxSing = 6;
	public int fun = 0;
	private float ticker = 0.1f;
    GameObject funText;
	// Use this for initialization
	void Start () {
        funText = GameObject.Find("Fun");
        humanSpawner = this.transform.GetComponent<HumanSpawner>();
	}
	
	// Update is called once per frame
	void Update () {
		ticker -= Time.deltaTime;
		if(ticker < 0)
		{
			ticker = 1.0f;
            // print fun
		}
	}

    private IEnumerator Singing(Transform person)
    {
        int notes = Random.Range(1, maxSing);
        for (int i = 0; i < notes; i++)
        {
            //Vector3 pos = person.gameObject.Find("body").Find("head").transform.position
            GameObject n = Instantiate(note, person.position + new Vector3(Random.Range(-0.3f,0.3f), Random.Range(4.8f, 5.2f), 0), Quaternion.identity);
            float r = Random.Range(0.05f, 0.2f);
            if(Random.Range(1,10) < 8)
            {
                n.transform.Find("noteSprite").GetComponent<SpriteRenderer>().color = Color.white;
            }
            Destroy(n, 15.0f);
			fun++;
            funText.GetComponent<TextMesh>().text = "Fun: " + fun.ToString();

            yield return new WaitForSeconds(r);

        }
 
    }

    public void Sing()
    {
        // make everyone sing
        foreach (Transform person in humanSpawner.humanList)
        {
            StartCoroutine(Singing(person));

        }
        maxSing++;
    }

    public void Drink()
    {
        StartCoroutine(Drinking());
    }

    private IEnumerator Drinking()
    {
        int newDrinks = Random.Range(3, 8);
        for (int i = 0; i < newDrinks; i++)
        {
            // xpos/zpos bounds
            // -2, 2, -3, 20
            Vector3 pos = new Vector3(Random.Range(-2, 2), Random.Range(2, 4), Random.Range(-6, 20));
            GameObject d = Instantiate(drink, pos, Quaternion.identity);
            fun += 22;
            funText.GetComponent<TextMesh>().text = "Fun: " + fun.ToString();
            yield return new WaitForSeconds(Random.Range(0.4f, 0.8f));
        }
    }
}
