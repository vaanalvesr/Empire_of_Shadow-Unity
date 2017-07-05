using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casa : MonoBehaviour {

    public Sprite casaImagem;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = casaImagem;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
