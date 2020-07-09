using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (ArcadeKart))]
public class ArcadeKartEditor : Editor {

    // OnInspector GUI
    public override void OnInspectorGUI () //2
    {

        // Call base class method
        base.OnInspectorGUI ();
        ArcadeKart player = (ArcadeKart) target;

        if (GUILayout.Button ("Generate blah")) {
            Debug.Log ("pressed");
        }

        // Custom form for Player Preferences

        // Custom Button with Image as Thumbnail
    }
}