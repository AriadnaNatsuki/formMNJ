using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace form_MNJ.Controllers;

public class Home:Controller
{
    //peticion GET  /home
    public IActionResult Index()
    {
        return View();
    }
    /*public string Index(string name, int ID=1){
        return HtmlEncoder.Default.Encode($"Hello {name} ID:{ID}")
    }*/
    //peticion GET /home/form
    public IActionResult Form(string name){
        ViewData["Message"]="Welcome "+name +", please fill up your candidate data 💼" ;
        return View();
    }
    public IActionResult Privacy(){
        return View();
    }

}