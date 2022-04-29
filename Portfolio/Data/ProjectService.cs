using Microsoft.EntityFrameworkCore;

namespace Portfolio.Data;

public class ProjectService
{
    public DatabaseContext DatabaseContext;

    public ProjectService(DatabaseContext databaseContext)
    {
        DatabaseContext = databaseContext;
    }

    public async Task<Project> GetProjectFromIdAsync(Guid id)
    {
       var result =await DatabaseContext.Projects.FirstOrDefaultAsync(project => project.Id == id);

       return result;
    }

    public async Task<List<Project>> GetAllProjectsAsync()
    {
        return await DatabaseContext.Projects.ToListAsync();
    }
}