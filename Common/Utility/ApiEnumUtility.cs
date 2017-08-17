using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Api验证提示
public enum ValidateTips : int
{
    [Remark("请求成功")]
    Success = 0,
    [Remark("无显示结果")]
    Success_NoResult = 1,
    [Remark("初始化异常")]
    Error_Init = -1000,
    [Remark("网络异常，请稍候再试")]
    Error_Net = -1001,
    [Remark("非法请求")]
    Error_Sign = -1002,
    [Remark("基本参数不正确")]
    Error_BaseParams = -1003,
    [Remark("请求时间格式不正确")]
    Error_TimeStamp = -1004,
    [Remark("请求链接已失效")]
    Error_Url = -1005,
    [Remark("业务参数不正确")]
    Error_BusinessParams = -1006
} 
#endregion