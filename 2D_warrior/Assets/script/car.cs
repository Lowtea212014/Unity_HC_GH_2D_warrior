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

    private void Test()
    {
        // 輸出 方法
        print("哈囉~");
    }

    // 傳回類型 int
    // 必須傳回 整數資料
    private int Ten()
    {
        // 傳回
        return 10;
    }

    private float OnePointFive()
    {
        return 1.5f;
    }

    private string Name()
    {
        return "KID";
    }

    // 維護擴充性
    private void DriveForward()
    {
        print("往前開");
        print("開車音效");
    }
    private void DriveBack()
    {
        print("往後開");
        print("開車音效");
    }
    private void DriveRight()
    {
        print("往右開");
        print("開車音效");
    }
    private void DriveLeft()
    {
        print("往左開");
        print("開車音效");
    }
    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="direction">方向</param>
    /// <param name="sound">音效</param>
    /// <param name="speed">速度</param>
    private void Drive(string direction, string sound, int speed)
    {
        print("開車方向：" + direction);
        print("開車音效：" + sound);
        print("開車速度：" + speed);
    }

    /// <summary>
    /// 開啟雨刷
    /// </summary>
    /// <param name="speed">雨刷速度</param>
    /// 參數預設值：選填式參數
    /// 選填式參數必須寫在最右方
    private void OpenBrush(string sound, int count = 2, int speed = 50)
    {
        print("開雨刷");
        print("音效：" + sound);
        print("雨刷的速度：" + speed);
        print("雨刷的數量：" + count);
    }
#endregion



}
