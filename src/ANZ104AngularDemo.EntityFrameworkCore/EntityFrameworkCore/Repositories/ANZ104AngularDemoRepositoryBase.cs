using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace ANZ104AngularDemo.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class ANZ104AngularDemoRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<ANZ104AngularDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ANZ104AngularDemoRepositoryBase(IDbContextProvider<ANZ104AngularDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="ANZ104AngularDemoRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class ANZ104AngularDemoRepositoryBase<TEntity> : ANZ104AngularDemoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ANZ104AngularDemoRepositoryBase(IDbContextProvider<ANZ104AngularDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)!!!
    }
}
