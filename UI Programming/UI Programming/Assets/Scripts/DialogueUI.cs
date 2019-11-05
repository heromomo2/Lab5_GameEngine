using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueUI : BaseUI
{
    public Anchor anchor;
    public Rect shape;
    public bool isVisible;
    private Rect oldShape;
    private Anchor oldAnchor;



    //private ButtonUI Bun2, Bun1;



    public Anchor button1anchor;
    public Rect button1shape;
    public bool button1isVisible;
    private Rect button1oldShape;
    private Anchor button1oldAnchor;


    // private Vector2 newresolution;
    //Start is called before the first frame update
    void Start()
    {
        oldAnchor = anchor;
        oldShape = shape;
        SetPosition(shape.x, shape.y);
        SetSize(shape.width, shape.height);
        SetAnchor(anchor);

        GetinitScreenSize();
        Debug.Log("test3");


       // button1oldAnchor = anchor;
        //SetAnchor(button1oldAnchor);
        button1oldShape = button1shape;
        button1shape.x = shape.x +120;
        button1shape.y = shape.y + 135;
        button1shape.width = shape.width/ 3;
        button1shape.height = shape.height / 3;
        //SetPosition(shape.x + 150, shape.y + 150);
        //SetSize(shape.width, shape.height);
        //SetAnchor(anchor);
    }
    void ReDraw()
    {
        oldAnchor = anchor;
        oldShape = shape;
        SetPosition(shape.x, shape.y);
        SetSize(shape.width, shape.height);
        SetAnchor(anchor);

        //Bun1.SetPosition(shape.x, shape.y);
        //Bun1.SetPosition(50, 50);
        //button1oldAnchor = anchor;
        //SetAnchor(button1oldAnchor);

        button1oldShape = button1shape;
        button1shape.x = shape.x + 120;
        button1shape.y = shape.y + 135;
        button1shape.width = shape.width / 3;
        button1shape.height = shape.height / 3;

    }

    private void OnGUI()
    {
        if (VIsVisible())
        {
            GUI.Box(new Rect(GetPosX(), GetPosY(), GetWidth(), GetHeight()), "ARE YOU READY TO DIE");


            if (GUI.Button(new Rect( GetPosX()+120, GetPosY() +135 , GetWidth()/3  , GetHeight()/3) , "yes sir"))
            {
                Debug.Log("Button pressed!");
            }
            

        }

       
    }
     //Update is called once per frame
    void Update()
    {
        if (oldAnchor != anchor || oldShape != shape)
        {
            ReDraw();
        }
        else
        {
            oldAnchor = anchor;
            oldShape = shape;
           // button1oldAnchor = anchor;
        }


        if (GetScreenSize())
        {
            ChangeSizeAuto();
        }
    }
}
