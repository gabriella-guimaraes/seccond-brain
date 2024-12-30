using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using second_brain.API.ViewModel;
using second_brain.Domain.Entities;
using second_brain.Infra.Data.Repositories;


namespace second_brain.API.Controllers
{
    public class UsersController : Controller
    {
        //Teste
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly IMapper _mapper;

        public UsersController(IMapper mapper)
        {
            _mapper = mapper;
            
        }

        // GET: UsersController
        public ActionResult Index()
        {
            var userViewModel = _mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userRepository.GetAll());
            return View(userViewModel);
        }

        // GET: UsersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserViewModel user)
        {
            if(ModelState.IsValid)
            {
                var userDomain = _mapper.Map<UserViewModel, User>(user);
                _userRepository.Add(userDomain);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
