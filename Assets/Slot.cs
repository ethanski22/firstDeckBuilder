using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // Makes sure that you can't put two cards on top of each other
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DragItem dragItem = dropped.GetComponent<DragItem>();
            dragItem.parentAfterDrag = transform;
        }

    }
}
