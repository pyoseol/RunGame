﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObjec : MonoBehaviour {
    public float speed = 10f;
    

    private void Update() {
        if(!GameManager.instance.isGameover)

        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
