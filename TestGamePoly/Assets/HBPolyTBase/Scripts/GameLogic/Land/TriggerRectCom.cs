﻿using UnityEngine;
using System.Collections;
using System;

[AddComponentMenu("Battle/Trigger2D/Rect")]
[RequireComponent(typeof(BoxCollider))]
public class TriggerRectCom : TriggerColliderItem
{
    public BoxCollider rect
    {
        get
        {
            return cld as BoxCollider;
        }
    }

    private Vector2 m_sourceSize = Vector2.zero;
    public Vector2 sourceSize
    {
        get
        {
            return m_sourceSize;
        }
    }

    protected override void OnInit()
    {
        m_sourceSize = rect.size;
    }

    public override IList GetCurrentTrigger()
    {
        if (!enabled)
            m_len = 0;
        else
        {
            Bounds bds = rect.bounds;

            m_len = Physics2D.OverlapAreaNonAlloc(bds.min, bds.max, m_results, checkLayer);
        }
        return m_results;
    }

    public override void ResetSize()
    {
        rect.center = Vector3.zero;
        rect.size = m_sourceSize;
    }
}
