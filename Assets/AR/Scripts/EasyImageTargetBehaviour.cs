/**
* Copyright (c) 2015-2016 VisionStar Information Technology (Shanghai) Co., Ltd. All Rights Reserved.
* EasyAR is the registered trademark or trademark of VisionStar Information Technology (Shanghai) Co., Ltd in China
* and other countries for the augmented reality technology developed by VisionStar Information Technology (Shanghai) Co., Ltd.
*/

using UnityEngine;

namespace EasyAR
{
    public class EasyImageTargetBehaviour : ImageTargetBehaviour, ITargetEventHandler
    {
        protected override void Start()
        {
            base.Start();
            HideObjects(transform);
        }

        void HideObjects(Transform trans)
        {
            for (int i = 0; i < trans.childCount; ++i)
                HideObjects(trans.GetChild(i));
            if (transform != trans)
                gameObject.SetActive(false);
        }

        void ShowObjects(Transform trans)
        {
            for (int i = 0; i < trans.childCount; ++i)
                ShowObjects(trans.GetChild(i));
            if (transform != trans)
                gameObject.SetActive(true);
        }

        void ITargetEventHandler.OnTargetFound(Target target)
        {
            ShowObjects(transform);
        }

        void ITargetEventHandler.OnTargetLost(Target target)
        {
            HideObjects(transform);
        }

        void ITargetEventHandler.OnTargetLoad(Target target, bool status)
        {
        }

        void ITargetEventHandler.OnTargetUnload(Target target, bool status)
        {
        }
    }
}
