using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ANZ104AngularDemo.MultiTenancy.HostDashboard.Dto;

namespace ANZ104AngularDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}