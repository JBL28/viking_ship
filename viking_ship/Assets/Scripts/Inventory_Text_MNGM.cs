using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Text_MNGM : MonoBehaviour
{
    public TMP_Text text;
    public PLAYER_INFO user;
    public int Item_ID;

    /* ������ ID�� �´� �����۸�� ������ �ؽ�Ʈ ������Ʈ�� �����ϴ�. */
    void Update()
    {
        text.text = user.items[Item_ID].name + " : " + user.items[Item_ID].value;
    }
}
