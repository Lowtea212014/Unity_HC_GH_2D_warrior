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
    public AudioClip firesouce ;
    [Header("血量")]
    [Range(0, 200)]
    public int 血量 = 100;
    private AudioSource aud;
    private Rigidbody2D rig ;
    private Animator ani ;
    [Header("地面判定位移")]
    public Vector3 offset;
    [Header("地面判定位移")]
    public float radius = 0.3f;
    #endregion
    

    public float h;
    private void Start()
    {
        //getcomponent
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        aud = GetComponent <AudioSource >();
    }
    private void Update()
    {
        GetHorizontal();
        Move();
        Jump();
        Fire();
    }
    private void OnDrawGizmos()
    {   
        Gizmos.color = new Color(1, 0, 0, 0.35f);
        Gizmos.DrawSphere(transform.position + offset,radius);
    }
    //觸發事件
    [Header("keysound")]
    public AudioClip keysound;
    ///<param name="collistion">碰到的物件資訊</param>>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Key")
        {
            Destroy(collision.gameObject);
            aud.PlayOneShot(keysound, Random.Range(1.2f, 1.5f));
        }
    }
    //在unity內繪製圖示

    private void GetHorizontal()
    {
        h = Input.GetAxis("Horizontal");
    }
    private void Move()
    {
        //缸體.加速度=二維(水平*速度,0)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
        //如果 玩家 按下 D 就執行
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("按下D");
            transform.localEulerAngles = Vector3.zero;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("按下A");
            transform.localEulerAngles = new Vector3(0, 180, 0);
        }
        ani.SetBool("跑步開關", h != 0);
    }
    //跳躍
    private void Jump()
    {
        if (on_ground && Input.GetKeyDown(KeyCode.Space))
        {
            print("跳躍");
            rig.AddForce(new Vector2(0, jumphight));
            ani.SetTrigger("跳躍觸發");
        }
            Collider2D hit=Physics2D.OverlapCircle(transform.position + offset,radius,1 << 8 );
        if (hit)
        {
            on_ground = true;
        }
        else
        {
            on_ground = false;
        }
        //
        ani.SetFloat("跳躍", rig.velocity.y);
        ani.SetBool("是否在地面上",on_ground);
    }
    ///開槍
    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //音效來源.播放一次音效(音效片段,音量)
            print("開槍");
            aud.PlayOneShot(firesouce,Random.Range(1.2f,1.5f));
            //生成(物件)
            GameObject temp =Instantiate(bullet,bulletborn.position,bulletborn.rotation);
            //站存子彈.取得原建<缸體>().添加推力(生成點應編*子彈速度+生成點上方*高度)
            temp.GetComponent<Rigidbody2D>().AddForce(bulletborn.right * bulletspeed+bulletborn.up*150);
        }
    }
    ///受傷
}



