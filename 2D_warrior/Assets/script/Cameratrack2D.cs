using UnityEngine;

public class Cameratrack2D : MonoBehaviour
{
    [Header("目標物件")]
    public Transform target;
    [Header("追蹤速度"), Range(0, 100)]
    public float speed = 3.5f;
    
    //追蹤目標物件
    private void Track()
    {
        Vector3 posA = target.position;     //取得玩家座標
        Vector3 posB = transform.position;  //取得攝影機座標
        posA.z = -10;                       //將Z軸改為-10 
        posB = Vector3.Lerp(posB, posA, 0.5f * speed * Time.deltaTime); //差值
        transform.position = posB;                                     //更新攝影機座標
    }
    //比update還晚進行的更新
    private void LateUpdate()
    {
        Track();
    }
}
