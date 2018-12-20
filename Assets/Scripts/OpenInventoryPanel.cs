﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventoryPanel : MonoBehaviour
{
    public GameObject InventoryPanel;

    public void OpenPanel()
    {
        if(InventoryPanel != null)
        {
            bool isActive = InventoryPanel.activeSelf;

            InventoryPanel.SetActive(!isActive);
        }
    }
}
