using UnityEngine;

public class Ball_Colision_check : MonoBehaviour
{
    [SerializeField]
    private Animator Player_current_Animation;
    [SerializeField]
    private string StateName; //{ get; private set; }
    private AnimatorClipInfo[] clipInfo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Player_current_Animation = collision.GetComponent<Animator>();
            clipInfo = Player_current_Animation.GetCurrentAnimatorClipInfo(0);
            StateName = clipInfo[0].clip.name;
        }else if(collision.gameObject.CompareTag("Wall"))
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    public  string Get_Player_Aniamtion()
    {
        return StateName;
    }

}
