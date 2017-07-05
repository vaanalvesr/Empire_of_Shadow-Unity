using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peca : MonoBehaviour {

    public Sprite red;
    public Sprite blue;
    private SpriteRenderer spriteRenderer;
    public int life;
    public int attack;
    public int currentLife;
    public int defense;
    // Use this for initialization

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
