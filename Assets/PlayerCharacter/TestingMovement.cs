using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    public class TestingMovement : MonoBehaviour
    {
        //Variable to control character speed
        public float Speed;
        // Update is called once per frame
        void Update()
        {
            //If we press A and D key at the same time character dosen't do anything
            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                return;
            }
            //when player press D key character moves Right/forwards
            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            //When player presses A key character moves left/backwards
            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
        }
    }
}


