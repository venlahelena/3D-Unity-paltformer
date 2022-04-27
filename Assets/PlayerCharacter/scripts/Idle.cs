using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
   [CreateAssetMenu(fileName = "New State", menuName = "AbilityData/Idle")]

    public class Idle : StateData
    {
        public override void OnEnter(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
            CharacterControl c = characterStateBase.GetCharacterControl(animator);

            if (c.Jump)
            {
                animator.SetBool(TransitionParameter.Jump.ToString(), true);
            }

            //when player press D key character moves Right/forwards
            if (c.MoveRight)
            {   
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
            //When player presses A key character moves left/backwards
            if (c.MoveLeft)
            {
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
        }

        public override void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }
}
