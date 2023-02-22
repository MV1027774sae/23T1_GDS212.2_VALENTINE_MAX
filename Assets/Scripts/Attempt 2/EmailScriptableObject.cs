using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EmailScriptableObject", menuName = "ScriptableObjects/EmailScriptableObject")]
public class EmailScriptableObject : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite icon;
    public GameObject prefab;
}
