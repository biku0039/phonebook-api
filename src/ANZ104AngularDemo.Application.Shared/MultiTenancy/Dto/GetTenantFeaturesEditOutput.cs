using System.Collections.Generic;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Editions.Dto;

namespace ANZ104AngularDemo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}