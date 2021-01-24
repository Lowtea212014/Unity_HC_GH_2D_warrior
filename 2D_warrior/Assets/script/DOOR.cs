using UnityEngine;

public class DOOR : MonoBehaviour
{
    [Header("key")]
    public GameObject key;
    [Header("開門音效")]
    public AudioClip soundOpen;

    private Animator ani;
    private AudioSource aud;
    private void Start()
    {
        ani = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果玩家進入 並且 邀史以被吃掉 就開門
        if (collision.name == "一隻企鵝"&&key==null)
        {
            ani.SetTrigger("開門");
            aud.PlayOneShot(soundOpen, Random.Range(1.2f, 1.5f));
        }
    }
}
