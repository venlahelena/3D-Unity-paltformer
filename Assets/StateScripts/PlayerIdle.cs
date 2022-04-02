using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    //Inherits from CharacterStateBase script
    public class PlayerIdle : CharacterStateBase
    {
        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            
        }
    }
}
