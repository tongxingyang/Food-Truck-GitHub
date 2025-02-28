﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfToolGenerator : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (!Debug.isDebugBuild && PerfAuditController.Inst == null)
        {
            Destroy(this.gameObject);
        }
    }
}
