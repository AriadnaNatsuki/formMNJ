using Microsoft.AspNetCore.Mvc
using System.Text.Encodings.Web;
namespace form_MNJ.Controllers;

public class Home:Controller
{
    //peticion GET  /home
    public string Index(){
        return "This is my default action"
    }
    //peticion GET /home/form
    public string Form(){
        return "This is the form action method"
    }

}