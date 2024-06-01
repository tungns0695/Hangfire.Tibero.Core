using System;

namespace Hangfire.Tibero.Core.JobQueue
{
    internal class TiberoJobQueueProvider : IPersistentJobQueueProvider
    {
        private readonly IPersistentJobQueue _jobQueue;
        private readonly IPersistentJobQueueMonitoringApi _monitoringApi;

        public TiberoJobQueueProvider(TiberoStorage storage, TiberoStorageOptions options)
        {
            if (storage == null)
            {
                throw new ArgumentNullException(nameof(storage));
            }

            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            _jobQueue = new TiberoJobQueue(storage, options);
            _monitoringApi = new TiberoJobQueueMonitoringApi(storage);
        }

        public IPersistentJobQueue GetJobQueue()
        {
            return _jobQueue;
        }

        public IPersistentJobQueueMonitoringApi GetJobQueueMonitoringApi()
        {
            return _monitoringApi;
        }
    }
}