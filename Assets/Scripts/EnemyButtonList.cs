using UnityEngine;
using System.Collections;
using System;

public class EnemyButtonList : IComparable<EnemyButtonList>
{

	public Transform enemyBtn;

    public EnemyButtonList(Transform btn)
    {
        enemyBtn = btn;
    }

    public int CompareTo(EnemyButtonList other)
    {
        return 1;
    }
}
