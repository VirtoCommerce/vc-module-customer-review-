using System.Threading.Tasks;
using VirtoCommerce.CustomerReviews.Core.Models;

namespace VirtoCommerce.CustomerReviews.Core.Services
{
    public interface ICustomerReviewSearchService
    {
        Task<string[]> GetProductIdsOfModifiedReviewsAsync(ChangedReviewsQuery criteria);
    }
}
