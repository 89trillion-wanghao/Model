using UnityEngine;
/// <summary>
/// 动画控制脚本
/// </summary>
public class AnimatorControl : MonoBehaviour
{
    private Animator infantryAnimator;
    /// <summary>
    /// 游戏入口
    /// </summary>
    void Start()
    {
        infantryAnimator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // 三种动画状态之间切换
        if (Input.GetKeyDown(KeyCode.Z))
        {
            infantryAnimator.SetTrigger("ToStand");
        }
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            infantryAnimator.SetTrigger("ToRun");
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            infantryAnimator.SetTrigger("ToAttack");
        }

        
        // AnyState切换到各个动画状态
/*   
        if (Input.GetKeyDown(KeyCode.A))
        {
            infantryAnimator.SetInteger("ChangeInt",1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            infantryAnimator.SetInteger("ChangeInt",2);
        }      
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            infantryAnimator.SetInteger("ChangeInt",3);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            infantryAnimator.SetInteger("ChangeInt",0);
        }
*/    
    }
}
