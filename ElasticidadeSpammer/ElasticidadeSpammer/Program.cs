Console.WriteLine("Hello, Spammer!");

new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();
new Thread(ThreadWork).Start();

void ThreadWork() 
{
    string url = "https://fibonacciwebserviceapi.azure-api.net/Fibonacci";

    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri(url);

    while (true)
    {
        try
        {
            HttpResponseMessage response = client.GetAsync("?target=46").Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Successfull request");
            }
            else
            {
                Console.WriteLine("Failed request {0}", response.IsSuccessStatusCode);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed request - exception");
        }
    }
}