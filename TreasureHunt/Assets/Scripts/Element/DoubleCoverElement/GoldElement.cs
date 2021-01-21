// ****************************************************
//     文件：GoldElement.cs
//     作者：积极向上小木木
//     邮箱: positivemumu@126.com
//     日期：2021/1/20 15:57:16
//     功能：金币元素类
// *****************************************************

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldElement : DoubleCoverElement
{
    private GoldTypes goldType;

    public override void Awake()
    {
        base.Awake();
        elementContent = ElementContents.Gold;
    }

    public override void ChangeSprite()
    {
        Transform goldEffect = transform.Find("GoldEffect");
        if(goldEffect==null)
        {
            Instantiate(MapManager.Instance.mapData.GoldEffect,transform).name="GoldEffect";
        }
        LoadSprite(MapManager.Instance.mapData.Golds[(int)goldType]);
    }

    public override void HandlePlayer()
    {
        Transform goldEffect = transform.Find("GoldEffect");
        if(goldEffect!=null)
        {
            Destroy(goldEffect.gameObject);
        }
        Debug.Log("Get a Gold");
    }
}
