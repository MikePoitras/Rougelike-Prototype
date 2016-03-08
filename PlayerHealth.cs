using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
    static public Text UIHealth;
    //static public Text UIScore;
    static public int Health = 100;
    static public int Score = 0;


    // Use this for initialization
    void Start () {
        UIHealth = GameObject.Find("UIHealth").GetComponent<Text>();
        //UIScore = GameObject.Find("UIScore").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        GameObject go = col.gameObject;
        if (go.tag == "Enemy") {
            Health = Health - 10;
            UIHealth.text = "Player Health: " + Health + "%";
        }
            Debug.Log("Hit");
    }
}
