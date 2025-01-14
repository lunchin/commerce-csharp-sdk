﻿using System;
using System.Threading.Tasks;
using CommerceApiSDK.Models.Parameters;
using CommerceApiSDK.Models.Results;

namespace CommerceApiSDK.Services.Interfaces
{
    public interface IRealTimeInventoryService
    {
        Task<GetRealTimeInventoryResult> GetProductRealTimeInventory(
            RealTimeInventoryParameters parameters
        );
    }
}
