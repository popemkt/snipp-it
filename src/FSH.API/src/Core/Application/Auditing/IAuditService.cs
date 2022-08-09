namespace FSH.API.Application.Auditing;

public interface IAuditService : ITransientService
{
    Task<List<AuditDto>> GetUserTrailsAsync(Guid userId);
}