using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor.Animations;

public class Trial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string dir = "Assets/Animation/Motion Pack/dance";
        string[] files = Directory.GetFiles(dir, "*.anim");
        foreach(string file in files) {
            // Debug.Log(file);
            // AnimationClip clip = AssetDatabase.LoadAssetAtPath(file, typeof(AnimationClip)) as AnimationClip; stateA1.motion = clip;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
