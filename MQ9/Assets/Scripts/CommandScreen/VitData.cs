using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class contains the model of the vit data. It will need to map correctly to the JSON file we get from the current menu trainer
/// </summary>
public class VitData
{
    public int num;
    public string title;
    public string layout;
    public string htmlStr;
    public bool bind;
    public VitField[] fields;
}
