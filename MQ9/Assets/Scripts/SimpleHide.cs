using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHide : MonoBehaviour
{
    void HideParent()
    {
        this.transform.parent.gameObject.SetActive(false);
    }
}
