using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{

    public string name;

    [TextArea(2, 10)]
    public string[] sentences;
    // Start is called before the first frame update
}
