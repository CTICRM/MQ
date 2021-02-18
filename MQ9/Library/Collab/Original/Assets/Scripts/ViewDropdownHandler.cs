using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewDropdownHandler : MonoBehaviour
{
    GameObject map;
    //bool mapOn;
    // Start is called before the first frame update
    void Start()
    {
        map = GameObject.Find("Compass Image");
        //mapOn = true;
    }
}