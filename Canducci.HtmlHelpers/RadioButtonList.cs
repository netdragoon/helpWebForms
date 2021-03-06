﻿using System.Collections;
namespace System.Web.Mvc
{
    public sealed class RadioButtonList
    {
        #region Constructs
        
        public RadioButtonList(IEnumerable items, string dataValueField, string dataLabelField, object selectedValue = null)
        {
            Items = items;
            DataValueField = dataValueField;
            DataLabelField = dataLabelField;
            SelectedValue = selectedValue;
        }

        public RadioButtonList(IEnumerable items, string dataValueField, object selectedValue = null)
        {
            Items = items;
            DataValueField = dataValueField;
            DataLabelField = DataValueField;
            SelectedValue = selectedValue;
        }
        #endregion Constructs

        #region Property
        public string DataValueField { get; private set; }
        public string DataLabelField { get; private set; }
        public object SelectedValue { get; private set; }
        public IEnumerable Items { get; private set; }
        #endregion Property

        #region FabricRadioButtonList
        public static RadioButtonList Create(IEnumerable items, string dataValueField, string dataLabelField, object selectedValue = null)
        {
            return new RadioButtonList(items, dataValueField, dataLabelField, selectedValue);
        }
        public static RadioButtonList Create(IEnumerable items, string dataValueField, object selectedValue = null)
        {
            return new RadioButtonList(items, dataValueField, selectedValue);
        }
        #endregion FabricRadioButtonList
    }
}
