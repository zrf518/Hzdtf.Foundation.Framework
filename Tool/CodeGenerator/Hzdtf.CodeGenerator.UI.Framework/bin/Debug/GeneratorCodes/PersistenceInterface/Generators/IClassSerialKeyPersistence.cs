﻿using Hzdtf.Persistence.Contract.Standard.Data;
using System;
using System.Collections.Generic;
using System.Text;
using hzdtd.Model.Standard;

namespace hzdtd.Persistence.Contract.Standard
{
    /// <summary>
    /// 班级流水键持久化接口
    /// @ 黄振东
    /// </summary>
    public partial interface IClassSerialKeyPersistence : IPersistence<ClassSerialKeyInfo>
    {
    }
}