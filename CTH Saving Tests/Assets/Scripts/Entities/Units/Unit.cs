using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Entity
{
    public RuntimeList<Unit> unitList;

    public UnitData data;

    //public int currentHealthPoints;

    public string unitName;
    public UnitStatistics statistics;



    private void OnEnable()
    {
        LoadUnitData();
        entityList.Add(this);
        unitList.Add(this);
    }

    private void OnDisable()
    {
        entityList.Remove(this);
        unitList.Remove(this);
    }

    public override void EntityDebug()
    {
        Debug.Log("I am a unit!");
    }

    private void LoadUnitData()
    {
        if (data != null)
        {
            gameObject.name = data.unitName;
            unitName = data.unitName;
            gameObject.GetComponent<SpriteRenderer>().sprite = data.sprite;
            statistics = data.statistics;
        }
    }
}
