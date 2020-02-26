﻿using System.Collections.Generic;
using System.Threading.Tasks;
using VirtoCommerce.CustomerReviews.Core.Models;

namespace VirtoCommerce.CustomerReviews.Core.Services
{
    public interface IRatingService
    {
        Task CalculateAsync(IEnumerable<ReviewStatusChangeData> data);
        Task CalculateAsync(string storeId);
        Task<RatingProductDto[]> GetForStoreAsync(string storeId, IEnumerable<string> productIds);
        Task<RatingStoreDto[]> GetForCatalogAsync(string catalogId, IEnumerable<string> productIds);

    }
}
