// Copyright (c) 2015 - 2022 Doozy Entertainment. All Rights Reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement
// A Copy of the EULA APPENDIX 1 is available at http://unity3d.com/company/legal/as_terms

//.........................
//.....Generated Class.....
//.........................
//.......Do not edit.......
//.........................

using System.Collections.Generic;
// ReSharper disable All
namespace Doozy.Runtime.UIManager.Containers
{
    public partial class UIView
    {
        public static IEnumerable<UIView> GetViews(UIViewId.Player id) => GetViews(nameof(UIViewId.Player), id.ToString());
        public static void Show(UIViewId.Player id, bool instant = false) => Show(nameof(UIViewId.Player), id.ToString(), instant);
        public static void Hide(UIViewId.Player id, bool instant = false) => Hide(nameof(UIViewId.Player), id.ToString(), instant);

        public static IEnumerable<UIView> GetViews(UIViewId.RadialViews id) => GetViews(nameof(UIViewId.RadialViews), id.ToString());
        public static void Show(UIViewId.RadialViews id, bool instant = false) => Show(nameof(UIViewId.RadialViews), id.ToString(), instant);
        public static void Hide(UIViewId.RadialViews id, bool instant = false) => Hide(nameof(UIViewId.RadialViews), id.ToString(), instant);
        public static IEnumerable<UIView> GetViews(UIViewId.Recorder id) => GetViews(nameof(UIViewId.Recorder), id.ToString());
        public static void Show(UIViewId.Recorder id, bool instant = false) => Show(nameof(UIViewId.Recorder), id.ToString(), instant);
        public static void Hide(UIViewId.Recorder id, bool instant = false) => Hide(nameof(UIViewId.Recorder), id.ToString(), instant);
    }
}

namespace Doozy.Runtime.UIManager
{
    public partial class UIViewId
    {
        public enum Player
        {
            SessionList
        }

        public enum RadialViews
        {
            MainMenu
        }
        public enum Recorder
        {
            Inputs,
            Popup
        }    
    }
}