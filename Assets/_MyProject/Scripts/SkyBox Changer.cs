using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SkyboxDropdown : MonoBehaviour
{
    [SerializeField] Material[] skyboxes;
    [SerializeField] Dropdown dropdown;

    void Start()
    {
        PopulateDropDown();
    }

    private void PopulateDropDown()
    {
        //if (dropdown == null) return;
        
        // Populate the dropdown options with skybox names
        dropdown.ClearOptions();
        foreach (Material skybox in skyboxes)
        {
            dropdown.options.Add(new Dropdown.OptionData(skybox.name));
        }
    }

    public void OnDropdownValueChanged(int index)
    {
        RenderSettings.skybox = skyboxes[index];
    }
}