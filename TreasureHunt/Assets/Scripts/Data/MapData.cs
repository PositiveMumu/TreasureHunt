/****************************************************
    文件：MapData.cs
	作者：积极向上小木木
    邮箱: positivemumu@126.com
    日期：2020/12/6 22:2:19
	功能：地图数据
*****************************************************/

using UnityEngine;

[CreateAssetMenu(menuName = "MySubMenue/Create MyScriptableObject ")]
public class MapData : ScriptableObject 
{
    public GameObject[] MapBorder;
    public GameObject MapBackGround;
    public Sprite[] Tiles;
    public Sprite[] Numbers;
    public Sprite[] Traps;
    public GameObject FlagElement;
    public GameObject FlagEffect;
    public GameObject BaseElement;
    public GameObject UncoveredEffect;
}