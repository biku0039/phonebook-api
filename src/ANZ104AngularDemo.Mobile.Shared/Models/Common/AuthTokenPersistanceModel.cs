using System;
using Abp.AutoMapper;
using ANZ104AngularDemo.Sessions.Dto;

namespace ANZ104AngularDemo.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}