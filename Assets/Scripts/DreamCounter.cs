using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DreamCounter : ScriptableObject
{
    [SerializeField]
    private int dreams;

    public int dreamsConsumed
    {
        get { return dreams; }
        set { dreams = value; }
    }

}