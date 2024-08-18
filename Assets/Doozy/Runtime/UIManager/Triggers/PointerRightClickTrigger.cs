﻿// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

using Doozy.Runtime.Common.Utils;
using Doozy.Runtime.Signals;
using Doozy.Runtime.UIManager.Events;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Doozy.Runtime.UIManager.Triggers
{
    [AddComponentMenu("UI/Triggers/PointerRightClick")]
    public class PointerRightClickTrigger : SignalProvider, IPointerClickHandler
    {
        // #if UNITY_EDITOR
        // [UnityEditor.MenuItem("GameObject/UI/Triggers/PointerRightClick", false, 8)]
        // private static void CreateComponent(UnityEditor.MenuCommand menuCommand)
        // {
        //     GameObjectUtils.AddToScene<PointerRightClickTrigger>("PointerRightClick Trigger", false, true);
        // }
        // #endif
        
        /// <summary> Called when pointer right button is clicked over the trigger </summary>
        public PointerEventDataEvent OnTrigger = new PointerEventDataEvent();
        
        public PointerRightClickTrigger() : base(ProviderType.Local, "Pointer", "Right Click", typeof(PointerRightClickTrigger)) {}

        public void OnPointerClick(PointerEventData eventData)
        {
            if (UISettings.interactionsDisabled) return;
            if (eventData.button != PointerEventData.InputButton.Right) return;
            SendSignal(eventData);
            OnTrigger?.Invoke(eventData);
        }
    }
}
