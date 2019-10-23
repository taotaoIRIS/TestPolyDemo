/*
 * Copyright (C) 2018 Slicol Tang. All rights reserved.
 * 
 * Licensed under the MIT License (the "License"); 
 * you may not use this file except in compliance with the License. 
 * You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, 
 * software distributed under the License is distributed on an "AS IS" BASIS, 
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
 * either express or implied. 
 * See the License for the specific language governing permissions and limitations under the License.
*/


using UnityEngine.UI;

namespace SGF.Unity.UI.UILib.Control
{
    public class CtlProgressBar:UIControl
    {
        public Image imgProgressValue;
        public float progress = 0;


        void Start()
        {
            SetData(0f);
        }

        public override void SetData(object data)
        {
            this.progress = (float)data;
            imgProgressValue.fillAmount = progress;

        }
    }
}