using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour
{

    public static bool test;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(120, 0, 100 * 5, 60 * 5), "test"))
        {
            test = true;
            Application.LoadLevel("game");
        }

        if (GUI.Button(new Rect(120, 0, 100 * 5, 60 * 5), "no test"))
        {
            test = false;
            Application.LoadLevel("game");
        }
    }
}
