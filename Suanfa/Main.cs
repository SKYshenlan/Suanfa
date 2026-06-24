//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private RectTransform index;
    /// <summary>
    ///  生成
    /// </summary>
    public void AddJinling()
    {
        // 随机位置
        Vector2 pos = Random.insideUnitCircle * 490;
        GameObject go = Instantiate(Resources.Load<GameObject>("item"), GameObject.Find("Canvas").transform);
        go.transform.localPosition = pos;
        if (index != null)
        {
            // 起点
            Vector2 x = index.anchoredPosition;
            // 终点
            Vector2 y = go.GetComponent<RectTransform>().anchoredPosition;
            // 方向向量
            Vector2 dic = (y - x).normalized;
            // 距离
            float dir = Vector2.Distance(x, y);
            GameObject a = Instantiate(Resources.Load<GameObject>("a"), GameObject.Find("Canvas").transform);
            RectTransform c1 = a.GetComponent<RectTransform>();
            c1.anchoredPosition = x;
            // 改变方向
            c1.localRotation = Quaternion.Euler(0, 0, Mathf.Atan2(dic.y, dic.x) * Mathf.Rad2Deg);
            // 长度
            c1.sizeDelta = new Vector2(dir, 3);


        }
        index = go.GetComponent<RectTransform>();
    }
}
