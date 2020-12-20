using UnityEngine;

public class playerstat : MonoBehaviour
{
    [Header("speed")]
    [Range(0,1000)]
    public float speed = 10.5f;
    [Header("jumphight")]
    [Range(0, 3000)]
    public int jumphight = 100;
    [Header("do it on ground")]
    [Tooltip("是否在地板上,預設為否")]
    public bool on_ground = false;
    [Header("子彈屬性")]
    [Tooltip("子彈圖")]
     public GameObject bullet;
    [Header("子彈生成點")]
    [Tooltip("子彈生成的地方")]
    public Transform bulletborn;
    [Header("子彈速度")]
    [Tooltip("子彈飛行速度,單位是m/s")]
    [Range(0, 5000)]
    public int bulletspeed = 800;
    [Header("開槍音效")]
    [Tooltip("開槍時的音效")]
    public AudioClip 開槍音效 ;
    [Header("血量")]
    [Range(0, 200)]
    public int 血量 = 100;
    AudioSource 音樂來源;
    Rigidbody2D 剛體 ;
    Animator 動畫控制器 ;


}
