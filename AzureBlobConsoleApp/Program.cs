namespace AzureBlobConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // install nuget package : Azure.Storage.Blobs

            UploadFileToBlobAsync("DefaultEndpointsProtocol=https;AccountName=storageacctestdelete;AccountKey=nsaX7cSep7h38D5b2Z5pqWc0HipKTO4YhGW8U0SVFSDY2rgxAtRnojIwF3tU09AHkOD8yPP1Gj73+AStV0yu2g==;EndpointSuffix=core.windows.net", "testcontainer", "01 Programming Fundamentals 03.pdf").GetAwaiter().GetResult();
        }

        static async Task UploadFileToBlobAsync(string connectionString, string containerName, string filePath)
        {
            // Create a BlobServiceClient object which allows you to interact with the Blob service
            var blobServiceClient = new Azure.Storage.Blobs.BlobServiceClient(connectionString);
            // Create a container client
            var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            // Create the container if it does not already exist
            await containerClient.CreateIfNotExistsAsync();
            // Get a reference to a blob
            var blobClient = containerClient.GetBlobClient(Path.GetFileName(filePath));
            // Upload the file to the blob
            using (var fileStream = File.OpenRead(filePath))
            {
                await blobClient.UploadAsync(fileStream, true);
            }
            Console.WriteLine($"File {filePath} uploaded to blob {blobClient.Uri}");
        }
    }
}
