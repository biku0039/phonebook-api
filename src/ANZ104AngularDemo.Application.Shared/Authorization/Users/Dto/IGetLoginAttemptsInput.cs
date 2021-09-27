using Abp.Application.Services.Dto;

namespace ANZ104AngularDemo.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}