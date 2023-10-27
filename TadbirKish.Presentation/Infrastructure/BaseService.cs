﻿namespace TadbirKish.Presentation.Infrastructure
{
    using System.Net.Http.Json;
    using System.Text.Json;
  
        public abstract class BaseService : object
        {
            public BaseService(HttpClient http) : base()
            {
                JsonOptions =
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                    };

                Http = http;

                BaseUrl = "https://localhost:7085";

                RequestUri = $"{BaseUrl}/{GetApiUrl()}";
            }

            protected abstract string GetApiUrl();

            public string BaseUrl { get; set; }

            protected string RequestUri { get; set; }

            protected HttpClient Http { get; }

            protected JsonSerializerOptions JsonOptions { get; set; }

            protected virtual async Task<O> GetAsync<O>()
            {
                HttpResponseMessage response = null;

                try
                {
                    response =
                        await
                        Http.GetAsync(requestUri: RequestUri);

                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            O result =
                                await response.Content.ReadFromJsonAsync<O>();

                            return result;
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("The content type is not supported.");
                        }
                        catch (JsonException)
                        {
                            Console.WriteLine("Invalid JSON.");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    response.Dispose();
                }

                return default;
            }

            protected virtual async Task<O> GetAsyncById<O>(string id)
            {
                HttpResponseMessage response = null;

                try
                {
                    response =
                        await
                        Http.GetAsync(requestUri: RequestUri + $"/{id}");

                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            O result =
                                await response.Content.ReadFromJsonAsync<O>();

                            return result;
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("The content type is not supported.");
                        }
                        catch (JsonException)
                        {
                            Console.WriteLine("Invalid JSON.");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    response.Dispose();
                }

                return default;
            }

            protected virtual async Task<O> PostAsync<I, O>(I viewModel)
            {
                HttpResponseMessage response = null;
                try
                {
                    response =
                        await Http.PostAsJsonAsync
                        (requestUri: RequestUri, value: viewModel);

                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            O result =
                                await response.Content.ReadFromJsonAsync<O>();

                            return result;
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("The content type is not supported.");
                        }
                        catch (JsonException)
                        {
                            Console.WriteLine("Invalid JSON.");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    response.Dispose();
                }

                return default;
            }

            protected virtual async Task<O> PutAsync<I, O>(I viewModel)
            {
                HttpResponseMessage response = null;
                response.Headers.Add("AuthenticationToken", "");
                response.Headers.Add("SessionID", "");

                try
                {
                    response =
                        await Http.PutAsJsonAsync
                        (requestUri: RequestUri, value: viewModel);

                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            O result =
                                await response.Content.ReadFromJsonAsync<O>();

                            return result;
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("The content type is not supported.");
                        }
                        catch (JsonException)
                        {
                            Console.WriteLine("Invalid JSON.");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    response.Dispose();
                }

                return default;
            }

            protected virtual async Task<O> DeleteAsync<O>(string id)
            {
                HttpResponseMessage response = null;

                try
                {
                    response =
                        await Http.DeleteAsync(requestUri: RequestUri + $"/{id}");

                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {
                        try
                        {
                            O result =
                                await response.Content.ReadFromJsonAsync<O>();

                            return result;
                        }
                        catch (NotSupportedException)
                        {
                            Console.WriteLine("The content type is not supported.");
                        }
                        catch (JsonException)
                        {
                            Console.WriteLine("Invalid JSON.");
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    response.Dispose();
                }

                return default;
            }

            protected virtual async Task<O> GetAsyncByrequestRegistrationId<O>(string requestRegistrationId)
            {
                HttpResponseMessage response = null;
             

                response =
                        await
                        Http.GetAsync(requestUri: RequestUri + $"?requestRegistrationId={requestRegistrationId}");

                response.EnsureSuccessStatusCode();

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        O result =
                            await response.Content.ReadFromJsonAsync<O>();

                        return result;
                    }
                    catch (NotSupportedException)
                    {
                        Console.WriteLine("The content type is not supported.");
                    }
                    catch (JsonException)
                    {
                        Console.WriteLine("Invalid JSON.");
                    }
                }

                response.Dispose();

                return default;
            }

         
        }
    
}
