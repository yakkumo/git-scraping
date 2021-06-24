#region

using System;
using System.Threading.Tasks;
using GitScraping.Core.Helpers.Interfaces;

#endregion

namespace GitScraping.Infrastructure.DataAccess
{
    public sealed class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly GitScrapingContext _context;
        private bool _disposed;

        public UnitOfWork(GitScrapingContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        /// <inheritdoc />
        public async Task<int> Save()
        {
            var affectedRows = await _context
                .SaveChangesAsync()
                .ConfigureAwait(false);
            return affectedRows;
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed && disposing) _context.Dispose();

            _disposed = true;
        }
    }
}