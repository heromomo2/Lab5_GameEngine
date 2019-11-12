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


    [SerializeField]
    private List<BaseUI> UIElements = new List<BaseUI>();

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
    }
    void ReDraw()
    {
        oldAnchor = anchor;
        oldShape = shape;
        SetPosition(shape.x, shape.y);
        SetSize(shape.width, shape.height);
        SetAnchor(anchor);
    }

    private void OnGUI()
    {
        if (VIsVisible())
        {
         GUI.Box(new Rect(GetPosX(), GetPosY(), GetWidth(), GetHeight()), "ARE YOU READY TO DIE");


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
        
        }


        if (GetScreenSize())
        {
            ChangeSizeAuto();
            for (int i = 0; i <  UIElements.Count; i++)
            {
                UIElements[i].GetScreenSize( new Vector2 (GetWidth(),GetHeight()),new Vector2 (GetPosX(),GetPosY()));
                UIElements[i].ChangeSizeAuto();
            }
        }
    }
}
