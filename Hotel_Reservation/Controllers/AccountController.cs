using Hotel_Reservation.Models;
using Hotel_Reservation.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly HotelBookingContext context;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager,HotelBookingContext context)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.context = context;
        }
        public IActionResult Login()
        {
            return View(new LoginViewModel());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(loginViewModel.Email);
                user = (user != null) ? user : await userManager.FindByEmailAsync(loginViewModel.Email);
                if (user != null)
                {
                    var passwordChecked = await userManager.CheckPasswordAsync(user, loginViewModel.Password);
                    if (passwordChecked)
                    {
                        var response = await signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
                        if (response.Succeeded)
                        {
                           
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
                else
                   
                    ModelState.AddModelError(nameof(loginViewModel.Email), "Email is not Registered ");
            }

            TempData["Error"] = "Failed..!!";
            return View(loginViewModel);
        }



        public IActionResult Register()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationViewModel registrationViewModel)
        {
            if (ModelState.IsValid)
            {
                var userByEmail = await userManager.FindByEmailAsync(registrationViewModel.Email);
                var userNationalId = context.Users.SingleOrDefault(w => w.NationalId == registrationViewModel.NationalityId);
                var userByPhone = context.Users.SingleOrDefault(w=>w.PhoneNumber==registrationViewModel.PhoneNumber);

                if (userByEmail == null&&userByPhone==null&&userNationalId==null)
                {
                    var newUser = new User()
                    {UserName = registrationViewModel.Name,
                    PasswordHash=registrationViewModel.Password,
                    PhoneNumber = registrationViewModel.PhoneNumber,
                    NationalId=registrationViewModel.NationalityId,
                    Nationality=registrationViewModel.Nationality,
                     Email = registrationViewModel.Email                    };
                    var response = await userManager.CreateAsync(newUser, registrationViewModel.Password);
                    if (response.Succeeded)
                    {
                        await userManager.AddToRoleAsync(newUser, "User");
                        await signInManager.SignInAsync(newUser, true);
                        return RedirectToAction("Index", "Home");
                    }

                    
                }

                if (userByEmail != null)
                    
           ModelState.AddModelError(nameof(registrationViewModel.Email), "Email is already existing");
                 if (userNationalId != null)
                    
           ModelState.AddModelError(nameof(registrationViewModel.NationalityId), "National Id is already existing");
                 if (userByPhone != null)
                    
           ModelState.AddModelError(nameof(registrationViewModel.PhoneNumber), "Phone Number is already existing");

                return View(registrationViewModel);
            }

            return View(registrationViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
