using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject{

    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        public static VirtualInputManager Instance = null;

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            } else if(Instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        public bool MoveRight;
        public bool MoveLeft;

    }
}