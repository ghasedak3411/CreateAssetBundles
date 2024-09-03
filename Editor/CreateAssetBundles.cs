using UnityEditor;
using UnityEngine;
using System.IO;
public class CreateAssetBundles
{
   
    [MenuItem("MahdiBazei/Build AssetBundles for webgl _F7")]
    static void BuildAllAssetBundles_webgl()
    {
        string assetBundleDirectory = "Assets/___AssetBundle/webgl";
        if (!Directory.Exists(assetBundleDirectory))
            Directory.CreateDirectory(assetBundleDirectory);


        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.WebGL);
    }

    [MenuItem("MahdiBazei/Build AssetBundles for android _F6")]
    static void BuildAllAssetBundles_aandroid()
    {
        string assetBundleDirectory = "Assets/___AssetBundle/android";
        if (!Directory.Exists(assetBundleDirectory))
            Directory.CreateDirectory(assetBundleDirectory);


        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.Android);
    }

    [MenuItem("MahdiBazei/Build AssetBundles for ios _F5")]
    static void BuildAllAssetBundles_ios()
    {
        string assetBundleDirectory = "Assets/___AssetBundle/ios";
        if (!Directory.Exists(assetBundleDirectory))
            Directory.CreateDirectory(assetBundleDirectory);


        BuildPipeline.BuildAssetBundles(assetBundleDirectory, BuildAssetBundleOptions.None, BuildTarget.iOS);
    }



    [MenuItem("MahdiBazei/SetBundleName _F4")]
    static void SetBundleName()
    {
        string assetPath = AssetDatabase.GetAssetPath(Selection.activeInstanceID);
        AssetImporter.GetAtPath(assetPath).SetAssetBundleNameAndVariant(Selection.gameObjects[0].name, "");
    }
    
    [MenuItem("MahdiBazei/ClearCache _F3")]
    static void ClearCache()
    {
        Caching.ClearCache();
    }

    [MenuItem("MahdiBazei/deletePlayerPref _F2")]
    static void deletePlayerPref()
    {
        PlayerPrefs.DeleteAll();
    }
}