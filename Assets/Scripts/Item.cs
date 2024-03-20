using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // we need to create a canvas and put the item under that canvas so it can be freely moved
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        //We need to assign the pointer position to this item
    }
}
