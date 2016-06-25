using System;

namespace ProjectMerger.Security
{
    public interface ICredentialsRepository : IDisposable
    {
        void Insert(User user);
        User Get(Guid id);
        void Update(User user);
        void Save();
    }
}
