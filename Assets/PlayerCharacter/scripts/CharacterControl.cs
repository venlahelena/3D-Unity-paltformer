using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameProgrammingLanguageTermProject
{
    //Get the animation boolean paramete Walk for walk animation
    public enum TransitionParameter
    {
        Walk,
        Jump,
        ForceJumpTransition,
        Grounded,
    }

    public class CharacterControl : MonoBehaviour
    {

        //Variable for animations
        public Animator animator;

        //Variables fro movement
        public bool MoveRight;
        public bool MoveLeft;
        public bool Jump;
        public GameObject ColliderEdgePrefab;

        public List<GameObject> BottomSpheres = new List<GameObject>();
        public List<GameObject> FrontSpheres = new List<GameObject>();

        private Rigidbody rigidbody;
        public Rigidbody RIGID_BODY
        {
            get
            {
                if(rigidbody == null)
                {
                    rigidbody = GetComponent<Rigidbody>();
                }

                return rigidbody;
            }
        }

        private void Awake()
        {
            BoxCollider box = GetComponent<BoxCollider>();

            float bottom = box.bounds.center.y - box.bounds.extents.y;
            float top = box.bounds.center.y + box.bounds.extents.y;
            float front = box.bounds.center.z + box.bounds.extents.z;
            float back = box.bounds.center.z - box.bounds.extents.z;

            GameObject bottomFront = CreateEdgeSphere(new Vector3(0f, bottom, front));
            GameObject bottomBack = CreateEdgeSphere(new Vector3(0f, bottom, back));
            GameObject topFront = CreateEdgeSphere(new Vector3(0f, top, front));

            bottomFront.transform.parent = this.transform;
            bottomBack.transform.parent = this.transform;
            topFront.transform.parent = this.transform;

            BottomSpheres.Add(bottomFront);
            BottomSpheres.Add(bottomBack);

            FrontSpheres.Add(bottomFront);
            FrontSpheres.Add(topFront);

            float sectionHor = (bottomFront.transform.position - bottomBack.transform.position).magnitude / 5f;
            CreateMiddleSpheres(bottomFront, -this.transform.forward, sectionHor, 4, BottomSpheres);

            float sectionVer = (bottomFront.transform.position - topFront.transform.position).magnitude / 5f;
            CreateMiddleSpheres(bottomFront, this.transform.up, sectionVer, 4, FrontSpheres);

        }

        public void CreateMiddleSpheres(GameObject start, Vector3 direction, float section, int interations, List<GameObject> spheresList)
        {
            for (int i = 0; i < interations; i++)
            {
                Vector3 pos = start.transform.position + (direction * section * (i + 1));

                GameObject newObj = CreateEdgeSphere(pos);
                newObj.transform.parent = this.transform;
                spheresList.Add(newObj);
            }
        }

        public GameObject CreateEdgeSphere(Vector3 position)
        {
            GameObject obj = Instantiate(ColliderEdgePrefab, position, Quaternion.identity);
            return obj;
        }
    }
}
