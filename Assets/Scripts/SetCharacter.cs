using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCharacter : MonoBehaviour
{

    public SpriteRenderer charRender;
    public Sprite Ninja;
    public Sprite Knight;
    public Sprite Vampire;
    public Animator theAnimator;
    public RuntimeAnimatorController NinjaAnim;
    public RuntimeAnimatorController KnightAnim;
    public RuntimeAnimatorController VampireAnim;

    void Start()
    {
        int charcterNum = PlayerPrefs.GetInt("Player");
        if(charcterNum == 0)
        {
            charRender.sprite = Ninja;
            theAnimator.runtimeAnimatorController = NinjaAnim;
        }
        else if (charcterNum == 1)
        {
            charRender.sprite = Knight;
            theAnimator.runtimeAnimatorController = KnightAnim;
        }
        else if (charcterNum == 2)
        {
            charRender.sprite = Vampire;
            theAnimator.runtimeAnimatorController = VampireAnim;
        }
        else
        {
            charRender.sprite = Ninja;
            theAnimator.runtimeAnimatorController = NinjaAnim;
        }

        
    }

}
