using UnityEngine;

public class playerstat : MonoBehaviour 


{
    #region 欄位
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
    private AudioSource aud;
    private Rigidbody2D rig ;
    private Animator ani ;
    #endregion
    

    public float h;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();


    }
    private void Update()
    {
        GetHorizontal();
        Move();
        Jump();
    }
    private void GetHorizontal()
    {
        h = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        //缸體.加速度=二維(水平*速度,0)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }
    //跳躍
    private void Jump()
    {

    }
}



