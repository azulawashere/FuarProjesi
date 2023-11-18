using FuarProjesi.Models.AppRoles;
using FuarProjesi.Models.AppUsers.RequestModels;
using FuarProjesi.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
namespace FuarProjesi.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        readonly RoleManager<AppRole> _roleManager;
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;
        public HomeController(UserManager<AppUser> UserManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = UserManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequestModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                };

                IdentityResult result= await _userManager.CreateAsync(user,model.Password);
                if (result.Succeeded)
                {
                    #region AdminEklemeIcinTekKullanimlikKodlar
                    AppRole appRole = await _roleManager.FindByNameAsync("Admin"); //Admin ismindeki rolu bulabilirse Role nesnesini appRole'e atacak bulamazsa appRole null olacak
                    if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Admin" }); //Admin isminde bir rol yarattık
                    await _userManager.AddToRoleAsync(user, "Admin"); //appUser degişkeninin tuttuğu kullanıcı nesnesini Admin isimli Role'e ekledik 


                    #endregion

                   // await _userManager.AddToRoleAsync(user, "Member"); //Register artık bu kod sayesinde direkt Member rolüne sahip olacaktır

                    return RedirectToAction("Index");
                }

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user,"Member");
                    return RedirectToAction("SignIn");
                }
                foreach (IdentityError item in result.Errors)
                {

                    ModelState.AddModelError("",item.Description);
                }

            }
            return View(model);
        }
      
        public IActionResult SignIn(string returnUrl)
        {
            UserSingInRequestModel usModel = new()
            {
                ReturnUrl = returnUrl,
            };
            return View(usModel);
        }
        [HttpPost]
        public async Task<IActionResult> SignIn (UserSingInRequestModel model)
        {
            if (ModelState.IsValid)
            {
               
                AppUser user = await _userManager.FindByNameAsync(model.UserName);
                
                if (user == null)
                    return View(model);
                SignInResult result =   await  _signInManager.PasswordSignInAsync(user,model.Password,model.RememberMe,true);
              
                if (result.Succeeded)
                {
                    
                    if (!string.IsNullOrWhiteSpace(model.ReturnUrl)) return Redirect(model.ReturnUrl);
                    IList<string> roles = await _userManager.GetRolesAsync(user);

                    if(roles.Contains("Admin"))
                    {
                        return RedirectToAction("AdminPanel");
                    }
                    if (roles.Contains("Member"))
                    {
                        return RedirectToAction("Member");
                    }
                    // todo : buraya roller eklenicek ona gore sayfalara ve actionlara yönlendirilecek
                }

                else if (result.IsLockedOut)
                {


                    DateTimeOffset? lockOutEndDate = await _userManager.GetLockoutEndDateAsync(user);

                    ModelState.AddModelError("", $"Hesabınız {(lockOutEndDate.Value.UtcDateTime - DateTime.UtcNow).Minutes} dakika süreyle askıya alınmıstır");
                }
                else
                {
                    string message = "";

                    if (user != null)
                    {
                        int maxFailedAttempts = _userManager.Options.Lockout.MaxFailedAccessAttempts;// middlewaredaki maksimum hata sayınız ..._userManager'daki ise su ana kadar kac kez yanlıslık yaptıgınız
                        message = $"Eger {maxFailedAttempts - await _userManager.GetAccessFailedCountAsync(user)} kez daha yanlıs giriş yaparsanız hesabınız gecici olarak askıya alınacaktır ";
                    }
                    else
                    {
                        message = "Kullanıcı bulunamadı";
                    }

                    ModelState.AddModelError("", message);
                }
            }

            return View(model);
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        public IActionResult CreateRole()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleRequestModel model)
        {
            IdentityResult result = await _roleManager.CreateAsync(new() { Name = model.RoleName });
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn");
            }
            return View(model);
        }
        public IActionResult Member() { return View(); }
    }
}
