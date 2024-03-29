﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUI : BaseUI {
    public Anchor anchor;
    public Rect shape;
    public bool isVisible;
    private Rect oldShape;
    private Anchor oldAnchor;

    // Use this for initialization
    private Vector2 resolution;
    [SerializeField]
    private string Buttontext;
 
    void Start () {
        oldAnchor = anchor;
        oldShape = shape;
        SetPosition(shape.x, shape.y);
        SetSize(shape.width, shape.height);
        SetAnchor(anchor);


        GetinitScreenSize();
        // resolution = new Vector2(Screen.width, Screen.height);
        //Debug.Log("test3");


    }
    
    private void OnGUI()
    {
        if (VIsVisible()){
            if (GUI.Button(new Rect(GetPosX(), GetPosY(), GetWidth(), GetHeight()),Buttontext)){
                Debug.Log("Button pressed!");
            }
        }
       
    }

    void ReDraw(){
        oldAnchor = anchor;
        oldShape = shape;
        SetPosition(shape.x, shape.y);
        SetSize(shape.width, shape.height);
        SetAnchor(anchor);
    }

    // Update is called once per frame
    void Update () {
        if (oldAnchor != anchor || oldShape != shape){
            ReDraw();
        }
        else{
            oldAnchor = anchor;
            oldShape = shape;
        }

        VSetVisible(isVisible);

      
        if (GetScreenSize())
        {
            ChangeSizeAuto();
        }
      
      
    }
}
