﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    // Start is called before the first frame update

    public Animator anim;
    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey("space")){
            anim.SetBool("isWalking", true);
        }else {
            anim.SetBool("isWalking", false);
        }
    }
}
