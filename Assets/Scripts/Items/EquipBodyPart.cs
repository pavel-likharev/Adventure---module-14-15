using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipBodyPart : MonoBehaviour
{
    [SerializeField] private BodyParts bodyPart;

    public bool IsEmpty { get; private set; }

    public BodyParts GetBodyPart() => bodyPart;

    public Vector3 GetPosition() => transform.position;
}
