using ANZ104AngularDemo.EntityFrameworkCore;

namespace ANZ104AngularDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly ANZ104AngularDemoDbContext _context;

        public InitialHostDbBuilder(ANZ104AngularDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
