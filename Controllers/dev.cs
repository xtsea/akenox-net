// Credits @xpushz on Telegram 
// Copyright 2017-2025 (c) Randy W @xtdevs, @xtsea on Telegram
// Source: https://github.com/TeamKillerX
// Channel: @RendyProjects
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using customApi.Services;

[ApiController]
[Route("api/dev")]
public class DevController : ControllerBase
{
    [HttpGet("endpoint")]
    public async Task<IActionResult> GetEndpoint()
    {
        string endpoint = AkenoXDev.GetEndpoint("list-endpoint");
        using var httpClient = new HttpClient();
        string response = await httpClient.GetStringAsync(endpoint);
        var json = JsonSerializer.Deserialize<object>(response);
        return Ok(json);
    }

    [HttpGet("instagram-dl")]
    public async Task<IActionResult> InstagramDl([FromQuery] string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return BadRequest("URL is required");
        }
        try
        {
            string endpoint = AkenoXDev.GetEndpoint("instagram-dl");
            using var httpClient = new HttpClient();
            string requestUrl = $"{endpoint}?link={url}";
            string response = await httpClient.GetStringAsync(requestUrl);

            var json = JsonSerializer.Deserialize<object>(response);
            return Ok(json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, "Error");
        }
    }

    [HttpGet("facebook-dl")]
    public async Task<IActionResult> FacebookDl([FromQuery] string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return BadRequest("URL is required");
        }
        string endpoint = AkenoXDev.GetEndpoint("facebook-dl");
        using var httpClient = new HttpClient();
        string response = await httpClient.GetStringAsync($"{endpoint}?link={url}");
        var json = JsonSerializer.Deserialize<object>(response);
        return Ok(json);
    }
}