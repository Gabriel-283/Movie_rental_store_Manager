using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRentalStoreManager.BLL.Entities;
using MovieRentalStoreManager.BLL.Interfaces;
using NuGet.Protocol.Plugins;

namespace MovieRentalStoreManager.App.Controllers
{
    public class UserController : AbstractController
    {
        public IUserService UserService { get; private set; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }

        public IActionResult Index()
        {
            var result = UserService.List();

            return View(result.Value);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var result = UserService.FindById(id);

            return result.IsFailed ? RedirectToAction(nameof(Index)) : View(result.Value);
        }

        public IActionResult Edit(int id)
        {
            var result = UserService.FindById(id);

            return result.IsFailed ? RedirectToAction(nameof(Index)) : View(result.Value);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            var result = UserService.Add(user);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            var result = UserService.Update(id, user);

            return result.IsSuccess ? RedirectToAction(nameof(Index)) : RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var result = UserService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult List()
        {
            var result = UserService.List();

            return result.IsSuccess ? View() : GetErrorResult(result.ToResult());
        }
    }
}
