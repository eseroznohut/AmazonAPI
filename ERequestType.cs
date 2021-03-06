using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonAPI
{
    public enum ERequestType
    {
        SubmitFeed,
        SubmitFeedPurgeAndReplace,
        GetFeedSubmissionList,
        GetFeedSubmissionListByNextToken,
        GetFeedSubmissionCount,
        CancelFeedSubmissions,
        GetFeedSubmissionResult,
        ListFinancialEventGroups,
        ListFinancialEventGroupsByNextToken,
        ListFinancialEvents,
        ListFinancialEventsByNextToken,
        GetServiceStatus,
        GetInboundGuidanceForSKU,
        GetInboundGuidanceForASIN,
        CreateInvoundShipmentPlan,
        CreateInboundShipment,
        UpdateInboundShipment,
        GetPreorderInfo,
        ConfirmPreorder,
        GetPrepInstructionsForSKU,
        GetPrepInstructionsForASIN,
        PutTransportContent,
        EstimateTransportRequest,
        GetTransportContent,
        ConfirmTransportRequest,
        VoidTransportRequest,
        GetPackageLabels,
        GetUniquePackageLabels,
        GetPalletLabels,
        GetBillOfLading,
        ListInboundShipments,
        ListInboundShipmentsByNextToken,
        ListInboundShipmentItems,
        ListInboundShipmentItemsByNextToken,
        ListInventorySubpply,
        ListInventorySupplyByNextToken,
        GetFulfillmentPreview,
        CreateFulfillmentOrder,
        UpdateFulfillmentORder,
        GetFulfillmentOrder,
        ListAllFulfillmentORders,
        ListAllFulfillmentOrdersByNextToken,
        GetPackageTrackingDetails,
        CancelFulfillmentOrder,
        ListReturnReasonCodes,
        CreateFulfillmentReturn,
        GetEligibleShippingServices,
        CreateShipment,
        GetShipment,
        CancelShipment,
        ListOrders,
        ListOrdersByNextToken,
        GetORder,
        ListOrderItems,
        ListOrderItemsByNextToken,
        ListMatchingProducts,
        GetMatchingProduct,
        GetMatchingProductForId,
        GetCompetitivePricingForSKU,
        GetCompetitivePricingForASIN,
        GetLowestOfferListingsForSKU,
        GetLowestOfferListingsForASIN,
        GetLowestPricedOffersForSKU,
        GetLowestPRicedOffersForASIN,
        GetMyFeesEstimate,
        GetMyPriceForSKU,
        GetMyPriceForASIN,
        GetProductCategoriesForSKU,
        GetProductCategoriesForASIN,
        GetLastUpdatedTimeForRecommendations,
        ListRecommendations,
        ListRecommendationsByNextToken,
        RequestReport,
        GetReportRequestList,
        GetReportRequestListByNextToken,
        GetReportRequestCount,
        CancelReportRequests,
        GetReportList,
        GetReportListByNextToken,
        GetReportCount,
        GetReport,
        ManageReportSchedule,
        GetReportScheduleList,
        GetReportScheduleListByNextToken,
        GetReportScheduleCount,
        UpdateReportAcknowledgements,
        ListMarketplaceParticipations,
        ListMarketplaceParticipartionsByNextToken,
        RegisterDestination,
        DeregisterDestination,
        ListRegisteredDestinations,
        SendTestNotificationToDestination,
        CreateSubscription,
        GetSubscription,
        DeleteSubscription,
        ListSubscription,
        UpdateSubscripion,
        
    }
}
