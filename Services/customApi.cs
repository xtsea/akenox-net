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

namespace customApi.Services
{
    public class AkenoXDev
    {
        public static string GetEndpoint(string key)
        {
            return key switch
            {
                "list-endpoint" => "https://faster.maiysacollection.com/v2/fast/list-endpoint",
                "instagram-dl" => "https://faster.maiysacollection.com/v2/fast/instagram-dl",
                "facebook-dl" => "https://faster.maiysacollection.com/v2/fast/facebook-dl",
                _ => throw new ArgumentException("Invalid key", nameof(key))
            };
        }
        public static void FasterRun(WebApplication app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            if (!app.Environment.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }
            app.UseRouting();
            app.MapControllers();
            app.MapGet("/", context => {
                context.Response.Redirect("/swagger");
                return Task.CompletedTask;
            });
            app.MapGet("/support", context => {
                context.Response.Redirect("https://t.me/RendyProjects");
                return Task.CompletedTask;
            });
            app.Run();
        }
    }
}
