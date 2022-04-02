using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
   [CreateAssetMenu(fileName = "New State", menuName = "AbilityData/Idle")]

    public class Idle : StateData
    {
        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator)
        {
            //when player press D key character moves Right/forwards
            if (VirtualInputManager.Instance.MoveRight)
            {   
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
            //When player presses A key character moves left/backwards
            if (VirtualInputManager.Instance.MoveLeft)
            {
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
        }
    }
}
