using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
        [CreateAssetMenu(fileName = "New State", menuName = "AbilityData/MoveForward")]

        public class MoveForward : StateData
        {
            public AnimationCurve SpeedGraph;
            public float Speed;
            public float BlockDistance;

        public override void OnEnter(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }   

        public override void UpdateAbility(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {
                //Get character control from state base.
                CharacterControl c = characterStateBase.GetCharacterControl(animator);

                if(c.Jump)
                {
                    animator.SetBool(TransitionParameter.Jump.ToString(), true);
                }

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
                    if(!CheckFront(c))
                    {
                        c.transform.Translate(Vector3.forward * Speed * SpeedGraph.Evaluate(stateInfo.normalizedTime) * Time.deltaTime);
                        c.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                    }
                    
                }

                //When player presses A key character moves left/backwards
                if (c.MoveLeft)
                {
                    if (!CheckFront(c))
                    {
                        c.transform.Translate(Vector3.forward * Speed * SpeedGraph.Evaluate(stateInfo.normalizedTime) * Time.deltaTime);
                        c.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                    }
                }
        }

        public override void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo)
        {

        }

        bool CheckFront(CharacterControl c)
        {
            foreach (GameObject o in c.FrontSpheres)
            {
                RaycastHit hit;
                if (Physics.Raycast(o.transform.position, c.transform.forward, out hit, BlockDistance))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
