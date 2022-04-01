using UnityEngine;

public class Ball_Colision_check : MonoBehaviour
{
    [SerializeField]
    private Animator Player_current_Animation;
    [SerializeField]
    private string StateName; //{ get; private set; }
    private AnimatorClipInfo[] clipInfo;

    public bool Ball_Spiked;
    public bool ball_is_lobed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Player_current_Animation = collision.GetComponentInParent<Animator>();
            clipInfo = Player_current_Animation.GetCurrentAnimatorClipInfo(0);
            StateName = clipInfo[0].clip.name;
            Debug.Log("hit with: " + StateName);
        }else if(collision.gameObject.CompareTag("Wall"))
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    public bool Ball_Is_Spiked()
    {
        if(StateName.Equals("spike"))
        {
            Ball_Spiked = true;
        }
        else
        {
            Ball_Spiked = false;
        }

        return Ball_Spiked;
    }
    public bool Check_If_Lobe()
    {
        if (StateName.Equals("lob"))
        {
            ball_is_lobed = true;
        }
        

        return ball_is_lobed;
    }
    public  string Get_Player_Aniamtion()
    {
        return StateName;
    }

}
