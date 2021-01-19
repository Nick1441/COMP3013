using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HoverScript : MonoBehaviour
{
    public UnityEvent ClickedEvent;
    public void OnMouseEnter()
    {
        this.GetComponent<Animator>().SetTrigger("HoverOn");
    }

    public void OnMouseExit()
    {
        this.GetComponent<Animator>().SetTrigger("HoverOff");
    }

    public void OnMouseUp()
    {
        ClickedEvent.Invoke();
    }
}
