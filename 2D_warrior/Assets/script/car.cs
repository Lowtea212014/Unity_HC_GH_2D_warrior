using UnityEngine;

public class car : MonoBehaviour
{
    // last update 20201220
    // 註解用雙斜
    // 修飾詞 private：不顯示  pubulic ：顯示
    // 指定使用 "="
    // 字串要加雙引號
    [Header("car data")] //標題
    [Tooltip("height unit is meter")] //提示
    [Range(1,12)] //範圍
    public int height = 12;//public 顯示 int 為表示值為整數 
    [Tooltip("weight unit is kilogram")]
    [Range(10f,20f)]
    public float weight = 10.5f; // float 表示值為有小數點
    [Tooltip("brand is name")]
    public string brand = "dio"; // string 表示字串,可以輸入字元
    [Tooltip("car sky windows")]
    public bool haswindows = true; //bool 值為 有 及 無 表示為 true or false

    [Header("color")] //顏色
    public Color mycolor = new Color(0.1f, 0.1f, 0, 0.9f);
    public Color red = Color.red;

    [Header("座標")]
        public Vector2 V2one = Vector2.one;
    public Vector3 v3zero = new Vector3 (1f, 2f, 3f);
    [Header("圖片與音效")]
    public Sprite picture;
    public AudioClip sound;

    [Header("摺疊屬性與元件")]
    public Transform tras;
    public Camera CMR ;
        



    
}
