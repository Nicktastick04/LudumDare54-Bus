using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile_Entity_Controller : MonoBehaviour, IDropHandler
{

    public void OnDrop(PointerEventData eventData){
        if (transform.childCount == 0) {
            GameObject dropped = eventData.pointerDrag;
            Person_Dragging_Script draggablePerson = dropped.GetComponent<Person_Dragging_Script>();
            draggablePerson.parentAfterDrag = transform;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
