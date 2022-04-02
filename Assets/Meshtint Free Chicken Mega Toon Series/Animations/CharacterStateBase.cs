using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    public class CharacterStateBase : StateMachineBehaviour
    {
        //Variable to store our character control
        private CharacterControl characterControl;

        //Get character control via animator. It is done only once if the variable is null.
        public CharacterControl GetCharacterControl(Animator animator)
        {
            if (characterControl == null)
            {
                characterControl = animator.GetComponentInParent<CharacterControl>();
            }
             return characterControl;
        }
    }
}
