using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class VitLoader : MonoBehaviour
{
    
    public Dictionary<int, VitData> AllVits = new Dictionary<int, VitData>();
    private int currentVitIndex;
    private VitData currentVit;
    public VitData CurrentVit
    {
        get { return currentVit; }
        set
        {
            // Whenever we change the current vit we need to reload the screen
            currentVit = value;
            reloadCommandScreenVits();
        }
    }
    public int CurrentVitIndex
    {
        get { return currentVitIndex; }
        set
        {
            currentVitIndex = Mathf.Clamp(value, 0, 99);
            VitIndexLabel.GetComponent<TextMeshProUGUI>().text = currentVitIndex.ToString();
            CurrentVit = AllVits[currentVitIndex];
        }
    }
    public VitField field;

    public GameObject CanvasPanel;             // This is the panel where we will dynamically instantiate labels
    public GameObject VitFieldLabel;             // This is the label prefab we are going to instantiate
    public GameObject VitIndexLabel;    // This is the index label we are showing temporarily to show the selected vit

    void Start()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        loadAllVits();

        sw.Stop();
        Debug.Log($"Loading all the json took {sw.Elapsed} ");


        // Create 40 instances of VitFieldLabel prefabs
        for (int i = 0; i < 40; i++)
        {
            // Instantiate a label prefab in the canvas panel
            // NOTE: We are using Grid Layout Group on the panel to handle placement of the labels
            GameObject go = Instantiate(VitFieldLabel, CanvasPanel.transform);
            go.name = $"Label_{i}";
        }

        // Set initial vit index to 0
        CurrentVitIndex = 0;
    }
    public void OnBtnDecrement()
    {
        CurrentVitIndex--;
    }
    public void OnBtnIncrement()
    {
        CurrentVitIndex++;
    }
    private void loadAllVits()
    {
        // Use Resources.Load to load the file as a TextAsset.
        // NOTE: Does not seem to work if you include the file extension .json
        TextAsset ta = Resources.Load("working_vits") as TextAsset;

        // NOTE: Unity's built-in JsonUtility cannot handle serialization of arrays or dictionaries. Here we are using newtonsoft's json library.
        List<VitData> temp = JsonConvert.DeserializeObject<List<VitData>>(ta.ToString());

        // Put the screens into the dictionary so they are accessable by their number
        foreach (VitData vd in temp)
        {
            AllVits.Add(vd.num, vd);
        }
    }
    private void reloadCommandScreenVits()
    {
        // Index is used to determine how many of the 40 cells are populated so that the unused ones (if any) may be blanked out
        int index = 0;
        // Get all the fields from the vit
        for (int i = 0; i < CurrentVit.fields.Length; i++)
        {
            // Find the correct label object for the index we are at
            GameObject go = CanvasPanel.transform.Find($"Label_{i}").gameObject;
            VitField vf = CurrentVit.fields[i];

            // Get the text component from lblTitle, and set it according to the field's title
            GameObject lblTitle = go.transform.Find("lblTitle").gameObject;
            TextMeshProUGUI tmp = lblTitle.GetComponent<TextMeshProUGUI>();
            tmp.text = vf.title;

           

            // Get the text component from lblVal and set the value
            GameObject lblVal = go.transform.Find("lblVal").gameObject;
            tmp = lblVal.GetComponent<TextMeshProUGUI>();

            // Check to see if the field has a value or a range and set one of the values accordingly
            // TODO: Check to see if the field has a YellowsReds entry and set label background color accordingly.
            //Some fields are supposed to be empty but still show a value of 0. Check to see if title == null before changing value
            if (vf.title == "" || vf.title == null) // If no title, then be blank
            {
                tmp.text = "";
            }
            else if (vf.range != null && vf.range.Length == 2) // If range, pick random value
            {
                float value = Random.Range(vf.range[0], vf.range[1]);
                tmp.text = $"{string.Format("{0:F1}", value)} {vf.units}";
            }
            else
                tmp.text = $"{vf.val} {vf.units}";

            index = i;
        }

        // Blank out the unused lables
        for (int i = index; i < 40; i++)
        {
            GameObject go = CanvasPanel.transform.Find($"Label_{i}").gameObject;

            GameObject lblTitle = go.transform.Find("lblTitle").gameObject;
            TextMeshProUGUI tmp = lblTitle.GetComponent<TextMeshProUGUI>();
            tmp.text = "";

            // Get the text component from lblVal and set the value
            GameObject lblVal = go.transform.Find("lblVal").gameObject;
            tmp = lblVal.GetComponent<TextMeshProUGUI>();
            tmp.text = "";
        }
    }
}