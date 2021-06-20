using Microsoft.AspNetCore.Hosting;
using Solak_Simulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Solak_Simulator.Services
{
    public class JsonFileDropServices
    {
       
        
            public JsonFileDropServices(IWebHostEnvironment webHostEnvironment)
            {
                WebHostEnvironment = webHostEnvironment;
            }

            public IWebHostEnvironment WebHostEnvironment { get; }

            private string JsonFileName
            {
                get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "comms.json"); }
            }

            public IEnumerable<Drops> GetDrops()
            {
                using (var jsonFileReader = File.OpenText(JsonFileName))
                {
                    return JsonSerializer.Deserialize<Drops[]>(jsonFileReader.ReadToEnd(),
                        new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                }
            }
        
    }
}