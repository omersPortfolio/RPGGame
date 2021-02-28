using UnityEngine;

namespace RPG.Core
{
    public class CameraFollow : MonoBehaviour
    {
       

        public Transform target;  
        
        int degrees = 2;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(1))
            {

                transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * degrees);
                //            transform.RotateAround (target.position, Vector3.left, Input.GetAxis ("Mouse Y")* dragSpeed);
            } else
                return;
        }        
    }

}