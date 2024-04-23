using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Entity/Unit")]
public class UnitData : ScriptableObject
{
    public string unitName;
    public Sprite sprite;
    public UnitStatistics statistics;
}
