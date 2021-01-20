using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PauseButtons : MonoBehaviour
{
    public UnityEvent ClickedEvent;
    public void OnMouseUp()
    {
        ClickedEvent.Invoke();
    }
}
