using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    //Get the animation boolean paramete Walk for walk animation
    public enum TransitionParameter
    {
        Walk,
    }

    public class CharacterControl : MonoBehaviour
    {
        //Variable to control character speed
        public float Speed;

        //Barable for animations
        public Animator animator;

        // Update is called once per frame
        void Update()
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
            }

            //when player press D key character moves Right/forwards
            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
            //When player presses A key character moves left/backwards
            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                
                //When character is moving aka player is pressing button to move animation should be played
                animator.SetBool(TransitionParameter.Walk.ToString(), true);
            }
        }
    }
}
