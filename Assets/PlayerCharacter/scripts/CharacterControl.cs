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
    }
}
