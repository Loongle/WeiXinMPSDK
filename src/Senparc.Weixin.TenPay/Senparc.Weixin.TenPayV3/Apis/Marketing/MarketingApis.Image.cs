﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2022 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2022 Senparc
  
    文件名：MarketingApis.Image.cs
    文件功能描述：微信支付V3营销工具接口
    
    
    创建标识：Senparc - 20210821
    
----------------------------------------------------------------*/

using Senparc.CO2NET.Extensions;
using Senparc.CO2NET.Helpers;
using Senparc.CO2NET.Trace;
using Senparc.Weixin.TenPayV3.Apis.Marketing;
using Senparc.Weixin.TenPayV3.Entities;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Senparc.Weixin.TenPayV3.Apis
{
    /// <summary>
    /// 微信支付V3营销工具接口
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter3_1_1.shtml 下的【营销工具】所有接口 &gt; 【图片上传接口】
    /// </summary>
    public partial class MarketingApis
    {
        #region 图片上传接口

        /// <summary>
        /// 图片上传接口(营销专用)
        /// <para>通过本接口上传图片后可获得图片url地址。图片url可在微信支付营销相关的API使用，包括商家券、代金券、支付有礼等。</para>
        /// <para>更多详细请参考 https://pay.weixin.qq.com/wiki/doc/apiv3/apis/chapter9_0_1.shtml </para>
        /// </summary>
        /// <param name="data">微信支付需要POST的Data数据</param>
        /// <param name="timeOut">超时时间，单位为ms </param>
        /// <returns></returns>
        public async Task<UploadImageReturnJson> UploadImage(UploadImageRequestData data, int timeOut = Config.TIME_OUT)
        {

            var url = ReurnPayApiUrl("https://api.mch.weixin.qq.com/{0}v3/marketing/favor/media/image-upload");
            TenPayApiRequest tenPayApiRequest = new(_tenpayV3Setting);
            return await tenPayApiRequest.RequestAsync<UploadImageReturnJson>(url, data, timeOut);
        }

        #endregion

    }
}
