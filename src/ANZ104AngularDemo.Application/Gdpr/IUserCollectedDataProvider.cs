using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
