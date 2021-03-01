using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Vector3[] Positions;
    public Quaternion[] Rotations;
    private int mCurrentIndex = 0;
    public float Speed = 0.050f;
   

    // Start is called before the first frame update
    void Start()
    {

        Matrix4x4 obl = Camera.main.projectionMatrix;
        //Encuadre de cámara
        obl[0, 2] = 0.2f;
        obl[1, 2] = -0.3f;
        //Traslación de cámara
        obl[0, 3] = -1.5f;
        obl[1, 3] = -10f;
        obl[2, 3] = -11f;

        Camera.main.projectionMatrix = obl;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPos = Positions[mCurrentIndex];
        Quaternion currentRot = Rotations[mCurrentIndex];

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (mCurrentIndex < Positions.Length - 1 && mCurrentIndex < Rotations.Length - 1)
                mCurrentIndex++;


        }
       
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (mCurrentIndex > 0 )
                mCurrentIndex--;
        }
     

        // Dampen towards the target rotation
       

        transform.position = Vector3.Lerp(transform.position, currentPos, Speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, currentRot, Time.deltaTime * Speed);
    }

    
}
// camara 1: 1.40129 -1.401298
//camara 2: rot -158.337 