using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // There is an image var for each image in the card that I made
    public Image image;
    public Image image2;
    public Image image3;
    public Image image4;
    public Image image5;

    [HideInInspector] public Transform parentAfterDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        // Because the mouse sees the image as a place to set the card down
        // we have to turn off what makes it so we can interact with images
        image.raycastTarget = false;
        image2.raycastTarget = false;
        image3.raycastTarget = false;
        image4.raycastTarget = false;
        image5.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);

        // Turn back on interacting with an image
        image.raycastTarget = true;
        image2.raycastTarget = true;
        image3.raycastTarget = true;
        image4.raycastTarget = true;
        image5.raycastTarget = true;
    }
}
