using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class CreateStatDataClass
{
    [MenuItem("Assets/FSM/StatDataManager")]
    public static StateDataManager CreateStatData()
    {
        StateDataManager asset = ScriptableObject.CreateInstance<StateDataManager>();
        AssetDatabase.CreateAsset(asset, "Assets/Data/StatDataManager.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
}

