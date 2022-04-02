using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    public class PlayerWalking : CharacterStateBase
    {
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
                  //If we press A and D key at the same time character should not react
            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                //When character is not moving aka player is not pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), false);
                return;
            }

            //When A or D movement buttons are not pressed walking naimtion should not be triggered
            if (!VirtualInputManager.Instance.MoveRight && !VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Walk.ToString(), false);
                return;
            }

            //when player press D key character moves Right/forwards
            if (VirtualInputManager.Instance.MoveRight)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            //When player presses A key character moves left/backwards
            if (VirtualInputManager.Instance.MoveLeft)
            {
                GetCharacterControl(animator).transform.Translate(Vector3.forward * GetCharacterControl(animator).Speed * Time.deltaTime);
                GetCharacterControl(animator).transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
           
        }
    }
}
