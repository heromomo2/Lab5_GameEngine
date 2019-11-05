using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour, IScreenElement {
    private float m_PosX, m_PosY, m_ZOrder;
    private float m_Width, m_Height;
    private bool m_bIsVisible;
    protected Anchor m_Anchor;

    private Vector2 currentScreenSize;
    private Vector2 formerScreenSize;
    private float screenChangeRatioX, screenChangeRatioY;

    // public Rect shape;


    public void GetinitScreenSize()
    {
        currentScreenSize = new Vector2(Screen.width, Screen.height);
    }

    public bool GetScreenSize()
    {

        if (currentScreenSize != new Vector2(Screen.width, Screen.height))
        {
            formerScreenSize = currentScreenSize;
            currentScreenSize = new Vector2(Screen.width, Screen.height);
            screenChangeRatioX = currentScreenSize.x / formerScreenSize.x;
            screenChangeRatioY = currentScreenSize.y / formerScreenSize.y;
            return true;
        }
        return false;
    }

    public void ChangeSizeAuto()
    {
        m_Width  *= screenChangeRatioX;
        m_Height *= screenChangeRatioY;
    }

    public enum Anchor{
        Top_Left,
        Bottom_Left,
        Top_Right,
        Bottom_Right,
        Centre,
        Bottom_Centre,
        Top_Centre,
        Left_Centre,
        Right_Centre
    }


    public BaseUI(){
        m_bIsVisible = true;
        m_PosX = m_PosY = 0;
        m_Width = 100;
        m_Height = 100;
        m_Anchor = Anchor.Top_Left;
    }

    public void SetPosition(float posX, float posY){
        m_PosX = posX;
        m_PosY = posY;
    }

    public float GetPosX(){
        return m_PosX;
    }

    public float GetPosY(){
        return m_PosY;
    }

    public void SetSize(float width, float height){
        m_Width = width;
        m_Height = height;
    }

    public float GetWidth(){
        return m_Width;
    }

    public float GetHeight(){
        return m_Height;
    }

    public void SetAnchor(Anchor anchor){
        m_Anchor = anchor;

        switch (m_Anchor){
            case Anchor.Top_Left:
                m_PosY = m_PosY - (m_Height / 100);// + (Screen.height / 2);//add
                m_PosX = m_PosX - (m_Width / 100);// + (Screen.width / 2);//add
               // Debug.Log("currentResolution: " + Screen.currentResolution);
                // ...
                break;
                

            case Anchor.Top_Right:
                m_PosY = m_PosY - (m_Height / 100);// + (Screen.height / 2);//add
                m_PosX = m_PosX - (m_Width);// + (Screen.width / 2);//add
              

                break;

            case Anchor.Top_Centre:
                m_PosY = m_PosY - (m_Height / 100);// + (Screen.height / 2);// add
                m_PosX = m_PosX - (m_Width / 2);// +(Screen.width / 2);//add
                // ...
                break;

            case Anchor.Bottom_Left:
                m_PosY = m_PosY - m_Height;// + (Screen.height / 2);
                m_PosX = m_PosX - (m_Width / 100);// + (Screen.width / 2);
                break;

            case Anchor.Bottom_Right:
                m_PosY = m_PosY - (m_Height);// + (Screen.height / 2) ;//add
                m_PosX = m_PosX - (m_Width * 1);// +  (Screen.width / 2);//add
                //...
                break;

            case Anchor.Bottom_Centre:
                m_PosY = m_PosY - m_Height;// + (Screen.height / 2); ;//add
                m_PosX = m_PosX - (m_Width / 2);// + (Screen.width / 2);//add
                //...
                break;

            case Anchor.Left_Centre:
                m_PosY = m_PosY - (m_Height / 2);// + (Screen.height / 2); ;//add
                m_PosX = m_PosX - m_Width; //+ (Screen.width / 2);//ad
                //...
                break;

            case Anchor.Right_Centre:
                m_PosY = m_PosY - (m_Height / 2);// + (Screen.height / 2); ;//add
                m_PosX = m_PosX - (m_Width / 100);// + (Screen.width / 2);//ad
                //...
                break;

            case Anchor.Centre:
                m_PosY = m_PosY - (m_Height / 2) ;
                m_PosX = m_PosX - (m_Width / 2) ;
               // Debug.Log("currentResolution: " + Screen.currentResolution);
                break;
        }
    }

    public bool VIsVisible(){ 
        return m_bIsVisible; 
    }

    public void VSetVisible(bool visible){
        m_bIsVisible = visible;
    } 

    public float VGetZOrder(){
        return m_ZOrder;
    }
    public void VSetZOrder(float zOrder){
        m_ZOrder = zOrder;
    }


    //
   // private Vector2 resolution;

   /* private void Start()
    {

        //res = new  Screen.currentResolution;
        resolution = new Vector2(Screen.width, Screen.height);
        Debug.Log("test3");

    }*/

   /* void Update()
    {
        //Debug.Log("test2");
        //if (resolution.x != Screen.width || resolution.y != Screen.height)
        //{
        //    // do your stuff

        //    m_Width = (Screen.width / 50);
        //    m_Height = (Screen.height / 50);

        //    Debug.Log("test1");
        //    resolution.x = Screen.width;
        //    resolution.y = Screen.height;
        //}

        if (GetScreenSize())
        {
            shape.width *= screenChangeRatioX;
            shape.height *= screenChangeRatioY;
        }

    }*/

}
