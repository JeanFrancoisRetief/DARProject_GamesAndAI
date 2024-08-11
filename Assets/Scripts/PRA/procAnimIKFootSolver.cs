using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class procAnimIKFootSolver : MonoBehaviour
{
    [SerializeField] private LayerMask terrainLayer = default;
    [SerializeField] private Transform body = default;
    [SerializeField] private float speed = 1;
    [SerializeField] private float stepDistance = 4;
    [SerializeField] private float stepLength = 4;
    [SerializeField] private float stepHeight = 1;
    [SerializeField] private Vector3 footOffset = default;

    private Vector3 targetLocation;

    //Vector3 footSpacing;
    float footSpacing;
    Vector3 oldPos, currentPos, newPos;
    Vector3 oldNormal, currentNormal, newNormal;
    float lerp;

    // Start is called before the first frame update
    void Start()
    {
        //footSpacing = transform.localPosition;
        footSpacing = transform.localPosition.x;
        currentPos = newPos = oldPos = transform.position;
        currentNormal = newNormal = oldNormal = transform.up;
        lerp = 1;

        targetLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(footSpacing);
        transform.position = currentPos;
        transform.up = currentNormal;

        //Ray ray = new Ray(body.position + (body.right * footSpacing), Vector3.down);
        //Ray ray = new Ray(transform.position, Vector3.down);
        Ray ray = new Ray(targetLocation, Vector3.down);

        //if(Physics.Raycast(ray, out RaycastHit info, 10, terrainLayer.value))
        //{
        //    if(Vector3.Distance(newPos, info.point) > stepDistance && !otherFoot.Ismoving() && lerp >= 1)
        //    {
        //        lerp = 0;
        //        int direction = body.InverseTransformPoint(info.point).z > body.InverseTransformPoint(newPos).z ? 1 : -1;
        //        newPos = info.point + (body.forward * stepLength * direction) + footOffset;
        //        newNormal = info.normal;
        //    }
        //}

        if (Physics.Raycast(ray, out RaycastHit info, 10, terrainLayer.value))
        {
            //Debug.Log("Hit");
            if (Vector3.Distance(newPos, info.point) > stepDistance && lerp >= 1)
            {
                lerp = 0;
                int direction = body.InverseTransformPoint(info.point).z > body.InverseTransformPoint(newPos).z ? 1 : -1;
                newPos = info.point + (body.forward * stepLength * direction) + footOffset;
                newNormal = info.normal;
            }
        }

        if (lerp < 1)
        {
            Vector3 tempPos = Vector3.Lerp(oldPos, newPos, lerp);
            tempPos.y += Mathf.Sin(lerp * Mathf.PI) * stepHeight;

            currentPos = tempPos;
            currentNormal = Vector3.Lerp(oldNormal, newNormal, lerp);
            lerp += Time.deltaTime * speed;
        }
        else
        {
            oldPos = newPos;
            oldNormal = newNormal;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(newPos, 0.5f);
    }

    public bool IsMoving()
    {
        return lerp < 1;
    }
}
