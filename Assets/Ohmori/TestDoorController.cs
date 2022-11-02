using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDoorController : MonoBehaviour, IOperatable
{
    public void GimmickOperate()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
}
