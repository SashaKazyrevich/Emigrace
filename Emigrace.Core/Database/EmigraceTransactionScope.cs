using System;
using System.Transactions;

namespace Emigrace.Core.Database
{
    public class EmigraceTransactionScope : IDisposable
    {
        private readonly TransactionScope _scope;

        public EmigraceTransactionScope(TimeSpan? timeout = null)
        {
            var options = new TransactionOptions {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = timeout ?? TimeSpan.FromSeconds(30)
            };
            _scope = new TransactionScope(TransactionScopeOption.Required, options);
        }

        public void Complete()
        {
            _scope.Complete();
        }

        public void Dispose()
        {
            _scope.Dispose();
        }
    }
}
