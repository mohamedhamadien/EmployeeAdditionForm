using EmployeeAdditionForm.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http;
using System.Text;

namespace EmployeeAdditionForm.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApiSetting _apiSettings;
        private readonly IHttpClientFactory _httpClientFactory;
        public EmployeeController(IOptions<ApiSetting> apiSetting, IHttpClientFactory httpClientFactory)
        {
            _apiSettings = apiSetting.Value;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{_apiSettings.BaseUrl}{_apiSettings.Services.GetAllEmployees}");

            if (response.IsSuccessStatusCode)
            {
                string Res = await response.Content.ReadAsStringAsync();
                List<EmployeeViewModel>? contents = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(Res);
                return View(contents);

            }
            else
            {
                ViewBag.response = "Error";
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync($"{_apiSettings.BaseUrl}{_apiSettings.Services.GetAllRoles}");

            if (response.IsSuccessStatusCode)
            {
                string Res = await response.Content.ReadAsStringAsync();
                List<RoleViewModel>? contents = JsonConvert.DeserializeObject<List<RoleViewModel>>(Res);
                ViewBag.Roles = contents;
                return View();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                var client = _httpClientFactory.CreateClient();

                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{_apiSettings.BaseUrl}{_apiSettings.Services.PostEmployee}", content);

                if (response.IsSuccessStatusCode)
                {
                    // Handle success (e.g., redirect to a success page)
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    string Res = await response.Content.ReadAsStringAsync();
                    var contents = JsonConvert.DeserializeObject<ErrorResponse>(Res);

                    // Handle failure (e.g., show an error message)
                    foreach (var error in contents.Errors)
                    {
                        //ModelState.AddModelError(contents.Errors.Keys.FirstOrDefault(), contents.Errors.Values.FirstOrDefault().FirstOrDefault());
                        ModelState.AddModelError(error.Key, error.Value.FirstOrDefault());

                    }
                    var response2 = await client.GetAsync($"{_apiSettings.BaseUrl}{_apiSettings.Services.GetAllRoles}");

                    if (response2.IsSuccessStatusCode)
                    {
                        string Res2 = await response2.Content.ReadAsStringAsync();
                        List<RoleViewModel>? contents2 = JsonConvert.DeserializeObject<List<RoleViewModel>>(Res2);
                        ViewBag.Roles = contents2;
                    }
                }
            }

            return View(model);
        }
    }
}
