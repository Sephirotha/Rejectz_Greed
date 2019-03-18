using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worldrotation : MonoBehaviour
{

    private Quaternion startingRotation;
    public float speed = 10;

    private float mFL_Rotation;

    void Start()
    {
        //save the starting rotation
        startingRotation = transform.rotation;
        mFL_Rotation = 270;
    }

    void Update()
    {
        //go to 45 degress with the right arrow
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StopAllCoroutines();
            mFL_Rotation += 90;

            if (mFL_Rotation == 360)
            {
                mFL_Rotation = 0;
            }

            print(mFL_Rotation);

            StartCoroutine(Rotate(mFL_Rotation));
        }

        //go to -45 degree with the left arrow
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StopAllCoroutines();
            mFL_Rotation -= 90;

            if (mFL_Rotation == -360)
            {
                mFL_Rotation = 0;
            }

            print(mFL_Rotation);

            StartCoroutine(Rotate(mFL_Rotation));
        }
    }

    IEnumerator Rotate(float rotationAmount)
    {
        Quaternion finalRotation = Quaternion.Euler(0, rotationAmount, 0) * startingRotation;

        while (transform.rotation != finalRotation)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, finalRotation, Time.deltaTime * speed);
            yield return 0;
        }
    }
}
