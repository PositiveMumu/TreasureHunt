# 密室寻宝

**作者：积极向上小木木 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 联系方式：PositiveMumu@126.com**

## 一、 项目介绍

游戏类型为横版2D无尽关卡。以扫雷玩法为基础，增加许多道具来丰富玩法。

## 二、多平台适配

项目原始平台为PC（windows/Mac），鼠标点击。若要适配移动平台请查找Input引用并添加手势识别。
项目中接受的鼠标操作为：鼠标左键单击、鼠标右键单击、鼠标中键单击、鼠标左右拖动。
在移动平台中可替换为：单击，双击，长按、拖动。也可以单击弹出菜单，给出“鼠标左键单击、鼠标右键单击、鼠标中键单击”三种选择。

## 三、项目信息及运行方法

1. 游戏使用Unity_2020.3.4f1c1开发。
2. 脚本IDE为Rider_2020.3。
3. 在项目中笔者使用了自己封装的A*寻路框架，项目地址：https://github.com/PositiveMumu/AIInGames。
4. 在项目中笔者使用了自己封装的简单资源池框架，项目地址：https://github.com/PositiveMumu/MFramework。

游戏主要分为两个场景，Start和Game。运行时请从Start场景开始运行。

项目原本使用Unity_2019.4.11f1版本开发。但是在最后打包时，在Windows系统上运行正常，在Mac 10.15系统上运行正常，但是在Mac 11.0/11.0.2上运行失败，不定时闪退/启动卡死。在升级到Unity_2020.2.0f1c1版本重新打包后问题被解决。

**如果打包后的可执行程序无法在系统上运行，可以考虑升级Unity版本重新打包项目并运行。**

*2021.05.20更新*

项目新增ProCamera2D插件实现相机跟随效果。由于ProCamera2D的实现效果与Cinemachine效果完全相同，在运行时并未提供选择相机的选项。读者可更改`GameStartWindow`脚本中的`EnterNextScene`方法，通过调`用EnterProCameraScene`函数和`EnterCinemachineScene`函数来进入不同的相机插件的场景（二者实现的功能完全相同，`EnterNextScene`方法中默认调用的是`EnterCinemachineScene`函数）。

## 四、 项目优化方法

本项目很简单，有很大的优化空间。读者可自行利用素材重新实现功能，素材中包含新手引导和成就模块都是本项目未实现的。

在使用笔者相同的实现方法（代码）时，有以下几个可以优化的方法。由于时间关系没有改动，需要或感兴趣的读者可自行实现。

1. 碰到陷阱人物退回上一步位置->提前判断下一步类型并决定是否移动
2. 使用稿子和炸药道具时泥土特效的判断
	- 稿子->未翻开的元素和小石块需要特效
	- 炸药->未翻开的元素、已翻开未拾取的双翻类元素和不可翻开类元素需要特效。
3. 洪泛优化：已经是数字节点的元素不再继续翻开。
4. 行走优化：当走过的路径是翻开的数字元素是不需要响应。

## 五、项目截图

![开始界面](README/开始界面.png)

![游戏界面](README/游戏界面.png)

![过关界面](README/过关界面.png)

![失败界面](README/失败界面.png)
