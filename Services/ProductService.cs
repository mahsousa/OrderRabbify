using OrderRabbify.DTOs;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


public class ProductService
{
    private static readonly HttpClient client = new HttpClient();

    public async Task<ProductDTO> GetProduct(int productId)
    {
        var url = $"https://localhost:44394/api/product/{productId}";
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var product = JsonSerializer.Deserialize<ProductDTO>(jsonResponse);
            return product;
        }
        else
        {
            throw new Exception("Falha ao retornar o produto");
        }
    }


}
