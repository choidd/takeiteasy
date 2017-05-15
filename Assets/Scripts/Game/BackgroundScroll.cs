﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    private float speed = 0.5f;

    Renderer render;
	// Use this for initialization
	void Start () {
        render = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        render.material.mainTextureOffset = offset;
	}
}
