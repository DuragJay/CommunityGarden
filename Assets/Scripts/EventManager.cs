using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ClickAction();
    public static event ClickAction OnClicked;
    public static event ClickAction stopClick;
    public static event ClickAction startClick;

    private Vector3 curPos;
    private Vector3 lastPos;

    public Vector2 touchPosition;
    // Start is called before the first frame update

    private void Start()
    {
        lastPos = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = touch.position;


            if (touch.phase == TouchPhase.Stationary)
            {
                OnClicked();

            }

            else if (touch.phase == TouchPhase.Ended)
            {
                stopClick();
            }

            else if (touch.phase == TouchPhase.Began)
            {
                startClick();
            }


        }


    }




}
