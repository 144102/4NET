using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.Azure;

namespace WorkerRole1
{
    public class WorkerRole : RoleEntryPoint
    {
        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

        public override void Run()
        {
            Trace.TraceInformation("WorkerRole1 is running");

            try
            {
                this.RunAsync(this.cancellationTokenSource.Token).Wait();
            }
            finally
            {
                this.runCompleteEvent.Set();
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            bool result = base.OnStart();

            Trace.TraceInformation("WorkerRole1 has been started");

            return result;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("WorkerRole1 is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("WorkerRole1 has stopped");
        }

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                    CloudConfigurationManager.GetSetting("Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString")
                );

                // Create the blob client.
                CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

                // Retrieve a reference to a container.
                CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");

                CloudBlobDirectory thumbnailsDirectory = container.GetDirectoryReference("Thumbnails");

                // Retrieve reference to a blob named "cover".
                CloudBlockBlob coverBlob = container.GetBlockBlobReference("cover");
                
                // Create or overwrite the "Cover" blob with contents from a local file.
                using (var fileStream = System.IO.File.OpenRead(@"C:\Sources\Local\AzureCloudService1\deadpool.png"))
                {
                    coverBlob.UploadFromStream(fileStream);
                }
                                
                // Save blob contents to a file.
                using (var fileStream = System.IO.File.OpenWrite(@"C:\Sources\Local\AzureCloudService1\deadpool2.png"))
                {
                    coverBlob.DownloadToStream(fileStream);
                }

                // Retrieve reference to a folder named "copyFromWorker".
                CloudBlobDirectory newDirectory = container.GetDirectoryReference("copyFromWorker");
               

                // Retrieve reference to a blob named "coverThumbnails".
                CloudBlockBlob coverThumbnailsBlob = newDirectory.GetBlockBlobReference("coverThumbnails");

                // Copy the the blob "cover" to "coverThumbnailsBlob"
                coverThumbnailsBlob.StartCopyFromBlob(coverBlob);

                // List the container's blob
                var list = container.ListBlobs();
                Trace.WriteLine("{0}'s content : ", container.Name);
                foreach (var item in list)
                {
                    if (item.GetType() == typeof(CloudBlockBlob))
                    {
                        Trace.WriteLine(string.Format("{0}", ((CloudBlockBlob)item).Name));
                    }

                }

                //On ne va executer qu'une seule fois l'exemple pour montrer
                await Task.Delay(3600000);
            }
        }
    }
}
