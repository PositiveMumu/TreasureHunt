// ****************************************************
//     文件：DoorElement.cs
//     作者：积极向上小木木
//     邮箱：positivemumu@126.com
//     日期：2021/1/21 9:19:35
//     功能：可通过的门元素类
// *****************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorElement : CantCoverElement
{
    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContents.Door;
        LoadSprite(MapManager.Instance.mapData.Door);
    }
}