using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        string url = "https://api.example.com/data"; // Replace with your actual API endpoint
        CancellationToken cancellationToken = default; // Create a cancellation token if needed

        try
        {
            var response = await new HttpClient().GetAsync(url, cancellationToken);

            // Check the response status code
            if (response.IsSuccessStatusCode)
            {
                // Read content as string
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            else
            {
                Console.WriteLine($"HTTP request failed with status code {response.StatusCode}");
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP request failed: {ex.Message}");
        }
    }
}
