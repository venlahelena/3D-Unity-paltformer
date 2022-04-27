using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
        [CreateAssetMenu(fileName = "New State", menuName = "AbilityData/MoveForward")]

        public class MoveForward : StateData
        {
            public float Speed;

        public override void OnEnter(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }   

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
                //Get character control from state base.
                CharacterControl c = characterStateBase.GetCharacterControl(animator);

                //If we press A and D key at the same time character should not react
                if (c.MoveRight && c.MoveLeft)
                {
                    //When character is not moving aka player is not pressing button to move animation should be played
                    animator.SetBool(TransitionParameter.Walk.ToString(), false);
                    return;
                }

                //When A or D movement buttons are not pressed walking naimtion should not be triggered
                if (!c.MoveRight && !c.MoveLeft)
                {
                    animator.SetBool(TransitionParameter.Walk.ToString(), false);
                    return;
                }

                //when player press D key character moves Right/forwards
                if (c.MoveRight)
                {
                    c.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    c.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }
                //When player presses A key character moves left/backwards
                if (c.MoveLeft)
                {
                    c.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                    c.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }

        public override void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }
    }
}
