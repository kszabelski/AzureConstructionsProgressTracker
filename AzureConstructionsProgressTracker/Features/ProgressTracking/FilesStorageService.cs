using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AzureConstructionsProgressTracker.Features.ProgressTracking
{
    public class FilesStorageService
    {
        private const string ContainerName = "constructionprogressfiles";
        private readonly CloudBlobContainer _container;
        private readonly StorageUri _blobStorageUri;

        public FilesStorageService(CloudStorageAccount storageAccount)
        {
            _blobStorageUri = storageAccount.BlobStorageUri;
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            _container = blobClient.GetContainerReference(ContainerName);
        }
        
        public async Task<string> UploadFile(string fileName, HttpPostedFileBase file)
        {
            if (!_container.Exists())
            {
                _container.Create();
                _container.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
            }

            CloudBlockBlob blockBlob = _container.GetBlockBlobReference(fileName);
            await blockBlob.UploadFromStreamAsync(file.InputStream);
            return $"{_blobStorageUri.PrimaryUri}{ContainerName}/{fileName}";
        }
    }
}