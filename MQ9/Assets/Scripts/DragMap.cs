using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Drags the map across the screen (while there is no mention of it,
// this script also drags the Tracker Cursor image as well)

public class DragMap : MonoBehaviour, IDragHandler
{
    #region IDragHandler implementation
	
	public void OnDrag(PointerEventData eventData) {
		this.transform.position += (Vector3)eventData.delta;
	}
	
	#endregion
}
