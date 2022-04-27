using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    public abstract class StateData : ScriptableObject
    {

        public abstract void OnEnter(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo);
        public abstract void UpdateAbility(CharacterStateBase characterStatebase, Animator animator, AnimatorStateInfo stateInfo);
        public abstract void OnExit(CharacterStateBase characterStateBase, Animator animator, AnimatorStateInfo stateInfo);
    }
}
