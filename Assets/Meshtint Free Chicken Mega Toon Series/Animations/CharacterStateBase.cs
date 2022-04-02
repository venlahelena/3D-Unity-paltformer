using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    public class CharacterStateBase : StateMachineBehaviour
    {
        //Variable that gets the State data
        public List<StateData> ListAbilityData = new List<StateData>();

        //Update state base list data
        public void UpdateAll(CharacterStateBase characterStateBase, Animator animator)
        {
            foreach (StateData d in ListAbilityData)
            {
                d.UpdateAbility(characterStateBase, animator);
            }
        }

        //Keep updating every frame
        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            UpdateAll(this, animator);
        }

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
