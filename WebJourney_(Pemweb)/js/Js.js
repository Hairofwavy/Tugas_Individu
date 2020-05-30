windows.onscroll = function()
{myFunction()};

var navbar = 
document.getElementsByClassName("submenu");
var sticky = submenu.offsetTop;

function myFunction(){
    if(window.pageYOffset >= sticky)
    {
        navbar.classList.add("sticky");
    } else {
        navbar.classList.remove("sticky");
    }
}