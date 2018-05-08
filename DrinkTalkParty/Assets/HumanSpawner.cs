using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour {

    public Color[] skins;
    public Color[] hair;
    public Color[] shirts;
	public Color[] eyes;
    public int humans;
    public Transform human;
    public Vector3[] startPoints;
    int layer1 = 2;
    int layer2 = 1;
    int layer3 = 0;
    public List<Transform> humanList = new List<Transform>();
    private float timer;

    private GameController gameController;
	// Use this for initialization
	void Start () {
        gameController = GameObject.Find("Main Camera").GetComponent<GameController>();
            timer = humans / 9; 
            StartCoroutine(SpawnHuman());
    
	}

    private IEnumerator SpawnHuman()
    {

            for (int j = 0; j < startPoints.Length; j++)
            {
                layer1 = 2;
                layer2 = 1;
                layer3 = 0;
            for (int i = 0; i < humans; i++)
                {
                Transform newHuman;
                    if(j == 0)
                {
                     newHuman = Instantiate(human, startPoints[j] + new Vector3(i * 0.3f, 0, i * 2.4f), Quaternion.identity);
                } else
                {
                     newHuman = Instantiate(human, startPoints[j] + new Vector3(i * -0.3f, 0, i * 2.4f), Quaternion.identity);
                }


                // colour randomly
                Color skinColour = skins[Random.Range(0, skins.Length)];
                newHuman.Find("body").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("head").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("right-upper-arm").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("right-upper-arm").Find("right-lower-arm").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("right-upper-arm").Find("right-lower-arm").Find("right-hand").GetComponent<SpriteRenderer>().color = skinColour;

                newHuman.Find("body").Find("left-upper-arm").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("left-upper-arm").Find("left-lower-arm").GetComponent<SpriteRenderer>().color = skinColour;
                newHuman.Find("body").Find("left-upper-arm").Find("left-lower-arm").Find("left-hand").GetComponent<SpriteRenderer>().color = skinColour;

                // colour hair
                Color hairColour = hair[Random.Range(0, hair.Length)];
                newHuman.Find("body").Find("head").Find("front-hair").GetComponent<SpriteRenderer>().color = hairColour;
                newHuman.Find("body").Find("head").Find("back-hair").GetComponent<SpriteRenderer>().color = hairColour;

				// colour eyes
				Color eyeColour = eyes[Random.Range(0, eyes.Length)];
				newHuman.Find("body").Find("head").Find("left-eye").GetComponent<SpriteRenderer>().color = eyeColour;
				newHuman.Find("body").Find("head").Find("right-eye").GetComponent<SpriteRenderer>().color = eyeColour;
				
                // Colour shirt
                Color shirtColour = shirts[Random.Range(0, shirts.Length)];
                newHuman.Find("body").Find("body-armor").GetComponent<SpriteRenderer>().color = shirtColour;



                // ensure the layer drawing works appropriately
                humanList.Add(newHuman);
                human.Find("body").GetComponent<SpriteRenderer>().sortingOrder = layer3;

                human.Find("body").Find("head").Find("left-eye").GetComponent<SpriteRenderer>().sortingOrder = layer1;
                    human.Find("body").Find("head").Find("right-eye").GetComponent<SpriteRenderer>().sortingOrder = layer1;
                    human.Find("body").Find("head").Find("eye-socket").GetComponent<SpriteRenderer>().sortingOrder = layer2;
                    human.Find("body").Find("head").Find("mouth").GetComponent<SpriteRenderer>().sortingOrder = layer2;
                    human.Find("body").Find("head").Find("front-hair").GetComponent<SpriteRenderer>().sortingOrder = layer2;
                    human.Find("body").Find("head").Find("back-hair").GetComponent<SpriteRenderer>().sortingOrder = layer3 - 1;
                    human.Find("body").Find("head").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("body-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-arm").Find("right-upper-arm-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-arm").Find("right-lower-arm").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-arm").Find("right-lower-arm").Find("right-lower-arm-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-arm").Find("right-lower-arm").Find("right-hand").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-arm").GetComponent<SpriteRenderer>().sortingOrder = layer3;

                human.Find("body").Find("left-upper-arm").Find("left-upper-arm-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-arm").Find("left-lower-arm").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-arm").Find("left-lower-arm").Find("left-lower-arm-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-arm").Find("left-lower-arm").Find("left-hand").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-arm").GetComponent<SpriteRenderer>().sortingOrder = layer3;

                human.Find("body").Find("right-upper-leg").Find("right-upper-leg-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-leg").Find("right-lower-leg").Find("right-lower-leg-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-leg").Find("right-lower-leg").Find("right-foot").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-leg").Find("right-lower-leg").Find("right-foot").Find("right-foot-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-leg").Find("right-lower-leg").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("right-upper-leg").GetComponent<SpriteRenderer>().sortingOrder = layer3;

                human.Find("body").Find("left-upper-leg").Find("left-upper-leg-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-leg").Find("left-lower-leg").Find("left-lower-leg-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-leg").Find("left-lower-leg").Find("left-foot").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-leg").Find("left-lower-leg").Find("left-foot").Find("left-foot-armor").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-leg").Find("left-lower-leg").GetComponent<SpriteRenderer>().sortingOrder = layer3;
                    human.Find("body").Find("left-upper-leg").GetComponent<SpriteRenderer>().sortingOrder = layer3;

                // human.Find("body").Find("left-upper-arm").Find("left-lower-arm").Find("left-hand").GetComponent<SpriteRenderer>().sortingOrder = layer3;
               
                if(Random.Range(1,10) < 5)
                {
                    newHuman.Find("body").Find("head").Find("back-hair").gameObject.SetActive(false);
                }

                layer1 -= 3;
                    layer2 -= 3;
                    layer3 -= 3;

                    yield return new WaitForSeconds(0.2f);

                
            }

        }
    }

    void setLayers()
    {

        foreach (Transform human in humanList)
        {
   

        }

    }
	
	// Update is called once per frame
	void Update () {
        if (timer < 0 && timer > -100)
        {
            setLayers();
            timer = -1000;
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }
}
